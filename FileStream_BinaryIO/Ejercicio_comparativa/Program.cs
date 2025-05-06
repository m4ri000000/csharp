using System;
using espacio_comparativa;
public class Program {
    public static void Main(){
        Comparativa Micomparativa = new Comparativa("HojaCalculo.csv");
        Micomparativa.GuardarCSV("DatosModificados.txt");
        Console.WriteLine(Micomparativa.ListarPreciosDeProducto("M5836"));
    }
}