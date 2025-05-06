using System;

public class Program
{
    public static void Main(string[] args)
    {
        Fecha hola = new Fecha(11, 11, 0001);

        Fecha Adios = new Fecha(11, 11, 2023);

        Console.WriteLine(hola.ToString());
        hola.Incrementar();
        Console.WriteLine(Adios.ToString());
        hola.Incrementar(20);
        Console.WriteLine(hola.ToString());
    }
}