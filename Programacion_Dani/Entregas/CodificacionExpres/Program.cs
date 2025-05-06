// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int numero;
        Console.WriteLine("Introduce un número:");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero < 10 && numero % 2 == 0)
        {
            Console.WriteLine("Caso 1");
        }
        else if (numero == 10)
        {
            Console.WriteLine("Caso 2");
        }
        else
        {
            Console.WriteLine("Caso 3");
        }
    }
}
