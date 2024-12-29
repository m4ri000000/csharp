using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Introduce 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numeros);

        Console.WriteLine("Los números ordenados de menor a mayor son:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}