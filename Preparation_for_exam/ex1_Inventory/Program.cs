
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace InventarioApp
{
    public interface IDescontable
    {
        decimal CalcularPrecioFinal();
    }

    public class Producto : IComparable<Producto>, IDescontable
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public static decimal IVA = 0.21m;

        public Producto(string codigo, string nombre, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }

        public virtual decimal CalcularPrecioFinal()
        {
            return Precio * (1 + IVA);
        }

#pragma warning disable CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
        public int CompareTo(Producto other)
#pragma warning restore CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
        {
            return string.Compare(Nombre, other?.Nombre, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"[{Codigo}] {Nombre} - Precio base: {Precio:C2}, Precio final: {CalcularPrecioFinal():C2}";
        }
    }

    public class ProductoPerecedero : Producto
    {
        public DateTime FechaCaducidad { get; set; }

        public ProductoPerecedero(string codigo, string nombre, decimal precio, DateTime fechaCaducidad)
            : base(codigo, nombre, precio)
        {
            FechaCaducidad = fechaCaducidad;
        }

        public override decimal CalcularPrecioFinal()
        {
            var dias = (FechaCaducidad - DateTime.Now).Days;
            if (dias <= 3)
                return Precio * 0.5m; // 50% descuento si está por caducar
            return base.CalcularPrecioFinal();
        }

        public override string ToString()
        {
            return base.ToString() + $" (Caduca: {FechaCaducidad:dd/MM/yyyy})";
        }
    }

    public class Inventario
    {
        private List<Producto> productos = new List<Producto>();

        public void AñadirProducto(Producto p)
        {
            if (productos.Exists(x => x.Codigo == p.Codigo))
                throw new Exception("Producto ya registrado.");
            productos.Add(p);
        }

        public void EliminarProducto(string codigo)
        {
            productos.RemoveAll(p => p.Codigo == codigo);
        }

        public Producto BuscarProducto(string codigo)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return productos.Find(p => p.Codigo == codigo);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public void MostrarTodos()
        {
            productos.Sort();
            foreach (var p in productos)
                Console.WriteLine(p);
        }

        public void GuardarEnArchivo(string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                foreach (var p in productos)
                {
                    if (p is ProductoPerecedero perecedero)
                    {
                        sw.WriteLine($"{p.Codigo};{p.Nombre};{p.Precio};{perecedero.FechaCaducidad:yyyy-MM-dd}");
                    }
                    else
                    {
                        sw.WriteLine($"{p.Codigo};{p.Nombre};{p.Precio};");
                    }
                }
            }
        }

        public void CargarDesdeArchivo(string ruta)
        {
            if (!File.Exists(ruta)) throw new FileNotFoundException("Archivo no encontrado.");
            productos.Clear();
            var lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                var partes = linea.Split(';');
                if (partes.Length >= 3)
                {
                    string cod = partes[0];
                    string nom = partes[1];
                    decimal precio = decimal.Parse(partes[2], CultureInfo.InvariantCulture);
                    if (partes.Length == 4 && DateTime.TryParse(partes[3], out DateTime fecha))
                        productos.Add(new ProductoPerecedero(cod, nom, precio, fecha));
                    else
                        productos.Add(new Producto(cod, nom, precio));
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Inventario inventario = new Inventario();
            try
            {
                inventario.AñadirProducto(new Producto("A001", "Teclado", 19.99m));
                inventario.AñadirProducto(new Producto("A002", "Ratón", 15.5m));
                inventario.AñadirProducto(new ProductoPerecedero("A003", "Batería", 12.0m, DateTime.Now.AddDays(2)));

                Console.WriteLine("Inventario actual:");
                inventario.MostrarTodos();

                inventario.GuardarEnArchivo("inventario.csv");

                Console.WriteLine("\nInventario cargado desde archivo:");
                Inventario nuevo = new Inventario();
                nuevo.CargarDesdeArchivo("inventario.csv");
                nuevo.MostrarTodos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}