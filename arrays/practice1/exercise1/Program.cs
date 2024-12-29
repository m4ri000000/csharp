using System;

class Program
{
    static void Main()
    {
        int suma = 0;
        int[] numeros = new int[10];

        Console.WriteLine("Introduce 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            suma += numeros[i];
        }

        double media = suma / 10.0;
        Console.WriteLine($"La media aritmética es: {media}");
    }
}