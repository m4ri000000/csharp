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

    public override bool Equals(object obj) => obj is Producto p && p.Codigo == Codigo;
    public override int GetHashCode() => Codigo.GetHashCode();
    public int CompareTo(Producto other) => Nombre.CompareTo(other?.Nombre);
    public override string ToString() => $"[{Codigo}] {Nombre}";
}

public class Inventario
{
    private List<Producto> productos = new List<Producto>();
    private decimal[,,] precios; // [producto, vendedor, zona]
    private string[] vendedores = new[] { "Amazon", "MediaMarkt", "PCBox" };
    private string[] zonas = new[] { "Norte", "Centro", "Sur" };

    public Inventario(string rutaCsv)
    {
        precios = new decimal[100, 3, 3]; // Suponiendo 100 productos como máximo
        LeerCSV(rutaCsv);
    }

    private void LeerCSV(string ruta)
    {
        try
        {
            var lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                // Formato: codigo;nombre;vendedor;zona;precio
                var datos = linea.Split(';');
                string codigo = datos[0];
                string nombre = datos[1];
                string vendedor = datos[2];
                string zona = datos[3];
                decimal precio = decimal.Parse(datos[4]);

                int prodIndex = ObtenerIndiceProducto(codigo, nombre);
                int vendIndex = Array.IndexOf(vendedores, vendedor);
                int zonaIndex = Array.IndexOf(zonas, zona);

                if (prodIndex >= 0 && vendIndex >= 0 && zonaIndex >= 0)
                {
                    precios[prodIndex, vendIndex, zonaIndex] = precio;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }
    }

    private int ObtenerIndiceProducto(string codigo, string nombre)
    {
        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].Codigo == codigo) return i;
        }
        productos.Add(new Producto(codigo, nombre));
        return productos.Count - 1;
    }

    public void GuardarCSV(string ruta)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                for (int i = 0; i < productos.Count; i++)
                {
                    for (int j = 0; j < vendedores.Length; j++)
                    {
                        for (int k = 0; k < zonas.Length; k++)
                        {
                            decimal precio = precios[i, j, k];
                            if (precio > 0)
                            {
                                sw.WriteLine($"{productos[i].Codigo};{productos[i].Nombre};{vendedores[j]};{zonas[k]};{precio}");
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar el archivo: " + ex.Message);
        }
    }

    public void MostrarPreciosProducto(string codigo)
    {
        int index = productos.FindIndex(p => p.Codigo == codigo);
        if (index == -1)
        {
            Console.WriteLine("Producto no encontrado.");
            return;
        }

        Console.WriteLine($"Precios para: {productos[index]}");
        for (int j = 0; j < vendedores.Length; j++)
        {
            for (int k = 0; k < zonas.Length; k++)
            {
                decimal precio = precios[index, j, k];
                if (precio > 0)
                {
                    Console.WriteLine($"  {vendedores[j]} ({zonas[k]}): {precio:C}");
                }
            }
        }
    }

    public void AñadirPrecio(string codigo, string nombre, string vendedor, string zona, decimal precio)
    {
        int i = ObtenerIndiceProducto(codigo, nombre);
        int j = Array.IndexOf(vendedores, vendedor);
        int k = Array.IndexOf(zonas, zona);

        if (j >= 0 && k >= 0)
        {
            precios[i, j, k] = precio;
        }
        else
        {
            Console.WriteLine("Vendedor o zona no válida.");
        }
    }

    public void MostrarTodo()
    {
        productos.Sort();
        foreach (var p in productos)
        {
            MostrarPreciosProducto(p.Codigo);
        }
    }
}

class Program
{
    static void Main()
    {
        Inventario inv = new Inventario("inventario.csv");

        inv.AñadirPrecio("P003", "Tablet", "Amazon", "Sur", 320.50m);
        inv.MostrarPreciosProducto("P003");

        inv.MostrarTodo();
        inv.GuardarCSV("inventario_actualizado.csv");
    }
}