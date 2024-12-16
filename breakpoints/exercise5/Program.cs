using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 3, 5, 7, 2, 8, 1 };
        int max = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > max)
            {
                max = numero;
            }
        }

        Console.WriteLine($"El número mayor es: {max}");
    }
}