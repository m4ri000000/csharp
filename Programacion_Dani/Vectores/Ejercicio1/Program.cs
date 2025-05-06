// (1) Solicitar 10 números por teclado y calcular su media aritmética.
using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Introduce un número: ");
                numero[i] = Convert.ToInt32(Console.ReadLine());
                suma += numero[i];
            }
            int resultado = suma / 10;
            Console.WriteLine("La media aritmética es: " + resultado);
        }
    }
}