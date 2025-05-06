// (2) Mostrar por pantalla los números del 1 al 100, colocando 10 números en cada fila a mostrar.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int i = 1;
        while (i <= 100)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{i,3} ");
                i++;
            }
            Console.WriteLine();
        }
    }
}