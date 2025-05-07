using System;

class Inventario
{
    private string[] productos = { "Teclado", "Ratón", "Monitor", "Impresora" };
    private string[] sucursales = { "Madrid", "Barcelona", "Sevilla" };

    private int[,] stock;

    public Inventario()
    {
        stock = new int[productos.Length, sucursales.Length];

        // Inicializar stock aleatorio
        Random rand = new Random();
        for (int i = 0; i < productos.Length; i++)
            for (int j = 0; j < sucursales.Length; j++)
                stock[i, j] = rand.Next(0, 20);
    }

    public void MostrarInventario()
    {
        Console.WriteLine("Inventario de Productos:\n");
        Console.Write("\t");
        foreach (var suc in sucursales)
            Console.Write($"{suc}\t");
        Console.WriteLine();

        for (int i = 0; i < productos.Length; i++)
        {
            Console.Write($"{productos[i]}\t");
            for (int j = 0; j < sucursales.Length; j++)
                Console.Write($"{stock[i, j]}\t");
            Console.WriteLine();
        }
    }

    public void BuscarProducto(string nombreProducto)
    {
        int fila = -1;

        // Búsqueda lineal
        for (int i = 0; i < productos.Length; i++)
        {
            if (productos[i].Equals(nombreProducto, StringComparison.OrdinalIgnoreCase))
            {
                fila = i;
                break;
            }
        }

        if (fila == -1)
        {
            Console.WriteLine("Producto no encontrado.");m
            return;
        }

        Console.WriteLine($"\nStock de '{productos[fila]}':");
        for (int j = 0; j < sucursales.Length; j++)
        {
            Console.WriteLine($"{sucursales[j]}: {stock[fila, j]} unidades");
        }
    }

    static void Main()
    {
        Inventario inv = new Inventario();
        inv.MostrarInventario();

        Console.Write("\nIntroduce el nombre de un producto para consultar: ");
        string buscado = Console.ReadLine();
        inv.BuscarProducto(buscado);
    }
}