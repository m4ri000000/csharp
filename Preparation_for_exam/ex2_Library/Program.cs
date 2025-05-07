using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BibliotecaApp
{
    public interface IAlquilable
    {
        bool EstaDisponible();
        void Alquilar();
        void Devolver();
    }

    public abstract class ItemBiblioteca : IComparable<ItemBiblioteca>, IAlquilable
    {
        public string Titulo { get; set; }
        public string Codigo { get; set; }
        public bool Prestado { get; private set; }

        public ItemBiblioteca(string codigo, string titulo)
        {
            Codigo = codigo;
            Titulo = titulo;
            Prestado = false;
        }

        public int CompareTo(ItemBiblioteca other)
        {
            return string.Compare(Titulo, other?.Titulo, StringComparison.OrdinalIgnoreCase);
        }

        public bool EstaDisponible() => !Prestado;
        public void Alquilar() => Prestado = true;
        public void Devolver() => Prestado = false;

        public override string ToString()
        {
            return $"{Codigo} - {Titulo} [{(Prestado ? "Prestado" : "Disponible")}]";
        }
    }

    public class Libro : ItemBiblioteca
    {
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public Libro(string codigo, string titulo, string autor, int paginas)
            : base(codigo, titulo)
        {
            Autor = autor;
            Paginas = paginas;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Autor: {Autor}, Páginas: {Paginas}";
        }
    }

    public class Revista : ItemBiblioteca
    {
        public int NumeroEdicion { get; set; }

        public Revista(string codigo, string titulo, int numeroEdicion)
            : base(codigo, titulo)
        {
            NumeroEdicion = numeroEdicion;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Edición: {NumeroEdicion}";
        }
    }

    public class Biblioteca
    {
        private Dictionary<string, ItemBiblioteca> catalogo = new Dictionary<string, ItemBiblioteca>();

        public void AgregarItem(ItemBiblioteca item)
        {
            if (catalogo.ContainsKey(item.Codigo))
                throw new Exception("Código duplicado.");
            catalogo[item.Codigo] = item;
        }

        public void EliminarItem(string codigo)
        {
            catalogo.Remove(codigo);
        }

        public void MostrarCatalogo()
        {
            var lista = new List<ItemBiblioteca>(catalogo.Values);
            lista.Sort();
            foreach (var item in lista)
                Console.WriteLine(item);
        }

        public void AlquilarItem(string codigo)
        {
            if (catalogo.TryGetValue(codigo, out var item))
                item.Alquilar();
            else
                throw new Exception("Item no encontrado.");
        }

        public void DevolverItem(string codigo)
        {
            if (catalogo.TryGetValue(codigo, out var item))
                item.Devolver();
            else
                throw new Exception("Item no encontrado.");
        }

        public void Guardar(string archivo)
        {
            var json = JsonSerializer.Serialize(catalogo.Values, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true });
            File.WriteAllText(archivo, json);
        }

        public void Cargar(string archivo)
        {
            if (!File.Exists(archivo)) throw new FileNotFoundException();
            var contenido = File.ReadAllText(archivo);
            var items = JsonSerializer.Deserialize<List<ItemBiblioteca>>(contenido, new JsonSerializerOptions
            {
                IncludeFields = true,
                Converters = { new ItemBibliotecaJsonConverter() }
            });

            catalogo.Clear();
            foreach (var item in items)
                catalogo[item.Codigo] = item;
        }
    }

    class Program
    {
        static void Main()
        {
            Biblioteca b = new Biblioteca();
            try
            {
                b.AgregarItem(new Libro("L001", "Cien Años de Soledad", "G. García Márquez", 471));
                b.AgregarItem(new Revista("R001", "National Geographic", 202));
                b.AgregarItem(new Libro("L002", "El Hobbit", "J.R.R. Tolkien", 300));

                b.AlquilarItem("L002");

                Console.WriteLine("Catálogo actual:");
                b.MostrarCatalogo();

                b.Guardar("biblioteca.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }

    // Convertidor personalizado para deserializar objetos heredados
    public class ItemBibliotecaJsonConverter : System.Text.Json.Serialization.JsonConverter<ItemBiblioteca>
    {
        public override ItemBiblioteca Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var root = jsonDoc.RootElement;
            string tipo = root.GetProperty("Codigo").GetString();

            if (tipo.StartsWith("L"))
                return JsonSerializer.Deserialize<Libro>(root.GetRawText(), options);
            if (tipo.StartsWith("R"))
                return JsonSerializer.Deserialize<Revista>(root.GetRawText(), options);

            throw new NotSupportedException("Tipo desconocido");
        }

        public override void Write(Utf8JsonWriter writer, ItemBiblioteca value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
        }
    }
}