// (1) Imprimir 10 veces la serie de números del 1 al 30 en una misma línea.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 1; j <= 30; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}