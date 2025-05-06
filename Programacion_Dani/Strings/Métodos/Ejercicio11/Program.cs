// (11) Crear un programa que pida al usuario 10 números decimales, calcule su media y luego muestre los que están por encima de la media.

using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numeros = new double[10];
        double suma = 0;

        Console.WriteLine("Ingrese 10 números decimales:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToDouble(Console.ReadLine());
            suma += numeros[i];
        }

        double promedio = suma / 10;

        Console.WriteLine($"\nEl promedio es: {promedio}");

        Console.WriteLine("\nLos números por encima del promedio son:");
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] > promedio)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
