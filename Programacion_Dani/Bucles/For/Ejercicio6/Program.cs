// (6) Para los números del 1 al 100, calcular la suma de todos, la suma de los pares y la suma de los múltiplos de tres.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int suma = 0, pares = 0, impares = 0;

        for (int i = 1; i <= 100; i++)
        {
            suma += i;
            if (i % 2 == 0)
            {
                pares += i;
            }
            if (i % 3 == 0)
            {
                impares += i;
            }
        }

        Console.WriteLine($"Suma de todos {suma}, pares {pares} y impares {impares}");
    }
}