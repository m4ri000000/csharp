using System;
using System.Collections.Generic;
using System.IO;

public class Producto : IComparable<Producto>
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }

    public Producto(string codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
    }

    public override bool Equals(object obj) => obj is Producto p && Codigo == p.Codigo;
    public override int GetHashCode() => Codigo.GetHashCode();
    public int CompareTo(Producto other) => string.Compare(Nombre, other?.Nombre, StringComparison.Ordinal);
    public override string ToString() => $"Código: {Codigo}, Nombre: {Nombre}";
}

public class Articulo
{
    public string Vendedor { get; set; }
    public Producto Producto { get; set; }
    public decimal Precio { get; set; }

    public Articulo(string vendedor, Producto producto, decimal precio)
    {
        Vendedor = vendedor;
        Producto = producto;
        Precio = precio;
    }

    public override string ToString() => $"{Vendedor} - {Producto.Nombre} ({Producto.Codigo}): {Precio:C2}";
}

public class Comparativa
{
    private List<Articulo> articulos = new List<Articulo>();

    public Comparativa(string rutaArchivo)
    {
        try
        {
            foreach (var linea in File.ReadAllLines(rutaArchivo))
            {
                var valores = linea.Split(';');
                if (valores.Length == 4)
                {
                    var vendedor = valores[0].Trim('"');
                    var codigo = valores[1].Trim('"');
                    var nombre = valores[2].Trim('"');
                    var precio = decimal.Parse(valores[3].Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                    articulos.Add(new Articulo(vendedor, new Producto(codigo, nombre), precio));
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error al leer el archivo CSV: {ex.Message}");
        }
    }

    public void GuardarCSV(string rutaArchivo)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                foreach (var articulo in articulos)
                {
                    writer.WriteLine($"\"{articulo.Vendedor}\";\"{articulo.Producto.Codigo}\";\"{articulo.Producto.Nombre}\";{articulo.Precio.ToString().Replace('.', ',')}");
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error al guardar el archivo CSV: {ex.Message}");
        }
    }

    public void AñadirArticulo(string vendedor, string codigo, string nombre, decimal precio)
    {
        foreach (var articulo in articulos)
        {
            if (articulo.Producto.Codigo == codigo && articulo.Vendedor == vendedor)
                throw new InvalidOperationException("El artículo ya existe.");
        }
        articulos.Add(new Articulo(vendedor, new Producto(codigo, nombre), precio));
    }

    public void ModificarPrecio(string codigo, string vendedor, decimal nuevoPrecio)
    {
        bool encontrado = false;
        foreach (var articulo in articulos)
        {
            if (articulo.Producto.Codigo == codigo && articulo.Vendedor == vendedor)
            {
                articulo.Precio = nuevoPrecio;
                encontrado = true;
                break;
            }
        }
        if (!encontrado) throw new InvalidOperationException("Artículo no encontrado.");
    }

    public string ListarPreciosDeProducto(string codigo)
    {
        List<string> resultados = new List<string>();
        foreach (var articulo in articulos)
        {
            if (articulo.Producto.Codigo == codigo)
            {
                resultados.Add($"{articulo.Vendedor}: {articulo.Precio:C2}");
            }
        }
        if (resultados.Count == 0) return $"No se encontraron precios para el producto con código {codigo}.";
        return "=== Precios del producto " + codigo + " ===\n" + string.Join("\n", resultados);
    }

    public override string ToString()
    {
        List<string> resultado = new List<string> { "=== Comparativa de precios ===" };
        List<Articulo> ordenados = new List<Articulo>(articulos);

        for (int i = 0; i < ordenados.Count - 1; i++)
        {
            for (int j = i + 1; j < ordenados.Count; j++)
            {
                if (ordenados[i].Producto.CompareTo(ordenados[j].Producto) > 0)
                {
                    var temp = ordenados[i];
                    ordenados[i] = ordenados[j];
                    ordenados[j] = temp;
                }
            }
        }

        foreach (var articulo in ordenados)
        {
            resultado.Add(articulo.ToString());
        }
        return string.Join("\n", resultado);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Comparativa comp = new Comparativa("datos.csv");
            comp.AñadirArticulo("MediaMarkt", "P002", "Smartphone", 599.99m);
            comp.ModificarPrecio("P001", "Amazon", 1150.00m);

            Console.WriteLine(comp.ListarPreciosDeProducto("P001"));
            Console.WriteLine(comp);

            comp.GuardarCSV("datos_actualizados.csv");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}