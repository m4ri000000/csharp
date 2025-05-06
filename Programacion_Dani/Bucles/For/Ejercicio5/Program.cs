// (5) Presenta por pantalla las suma de los número del 1 al 100.

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int suma = 0;
        for (int i = 1; i <= 100; i++)
        {
            suma += i;
            // Console.WriteLine($"{i} - {suma}");
        }
        Console.WriteLine(suma);
    }

}