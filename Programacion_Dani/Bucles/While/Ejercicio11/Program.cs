// (11) Leer números enteros hasta teclear cero, y nos muestre el máximo, el mínimo y la media de todos ellos.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num;

        Console.Write("Introduce un número entero: ");
        num = Convert.ToInt32(Console.ReadLine());
        int max = num, min = num;

        while (num != 0)
        {
            if (num > max)
            {
                max = num;
            }
            else if (num < min)
            {
                min = num;
            }
            Console.Write("Introduce un número entero: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("El número máximo es: " + max);
        Console.WriteLine("El número mínimo es: " + min);

    }
}