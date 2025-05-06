using System;
using espacio_comparativa;
public class Program
{
    public static void Main()
    {
        Comparativa Micomparativa = new Comparativa("HojaCalculo.csv");
        Micomparativa.AñadirProducto("MorganSL", "MP85", "MiMovilito", 600);
        Micomparativa.ModificarPrecio("MP85", "MorganSL", 800.7m);
        Console.WriteLine(Micomparativa.ListarPreciosDeProducto("MP85"));
        Console.WriteLine(Micomparativa);
        Micomparativa.GuardarCSV("DatosModificados.txt");
    }
}