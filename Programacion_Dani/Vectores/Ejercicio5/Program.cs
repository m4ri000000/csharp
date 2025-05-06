// (5) Crear un programa que pida al usuario 10 números decimales, calcule su media y luego muestre los que están por encima de la media.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        decimal suma = 0;
        int max = 4;
        decimal[] lista = new decimal[max];

        for (int i = 0; i < max; i++)
        {
            Console.Write("Introduce un número (Recuerda colocar la `,` NO el `.`): ");
            lista[i] = Convert.ToDecimal(Console.ReadLine());
            suma += lista[i];
        }

        decimal resultado = suma / max;
        Console.WriteLine($"La media es: {resultado}");

        Console.WriteLine("Números por encima de la media:");
        for (int i = 0; i < max; i++)
        {
            if (lista[i] > resultado)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}