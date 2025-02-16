using System;
class Program
{
    static void Main(string[] args)
    {
        Fecha fecha1 = new Fecha(); // Fecha por defecto: 01-ENE-70
        Console.WriteLine($"Fecha inicial: {fecha1}");
        fecha1.IncrementarDia();
        Console.WriteLine($"Fecha despues de incremento: {fecha1}");
        fecha1.IncrementarDias(40);
        Console.WriteLine($"Fecha despues de incremento de 40 dias: {fecha1}");
    }
}