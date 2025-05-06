/*(12) Solicitar un vector de 20 números enteros positivos, y solicitar un nuevo número entero positivo que debe ser buscado en el vector. En un nuevo vector, cada vez que el valor del vector inicial coincida con el número solicitado, debemos colocar un -1. 
Si no coincide, colocamos un 0. Al final debemos mostrar ambos vectores, el inicial sin modificar.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[20];
        int[] resultado = new int[20];

        Console.WriteLine("Ingrese 20 números enteros positivos:");

        for (int i = 0; i < 20; i++)
        {
            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out numeros[i]) && numeros[i] > 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
                }
            }
        }

        Console.WriteLine("Ingrese el número a buscar:");
        int numeroBusqueda = 0;
        bool entradaBusquedaValida = false;
        while (!entradaBusquedaValida)
        {
            if (int.TryParse(Console.ReadLine(), out numeroBusqueda) && numeroBusqueda > 0)
            {
                entradaBusquedaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
            }
        }

        for (int i = 0; i < 20; i++)
        {
            resultado[i] = (numeros[i] == numeroBusqueda) ? -1 : 0;
        }

        Console.WriteLine("\nVector inicial:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("\nVector resultado:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(resultado[i] + " ");
        }
        Console.WriteLine();
    }
}
