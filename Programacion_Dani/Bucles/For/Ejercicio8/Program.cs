// (8) Dado un número entero, calcular todos sus divisores.

using System;

public class Program
{
    public static void Main()
    {
        int num;
        Console.Write("Introduce un númer: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if ((num % i) == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}