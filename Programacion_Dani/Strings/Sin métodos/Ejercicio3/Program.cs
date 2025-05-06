// (3) Dada una cadena por teclado, mostrar la cadena al revés.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Escribe una frase: ");
        string? cadena = Console.ReadLine();

        // Invertir la cadena con un bucle creando una nueva string
        for (int i = cadena.Length - 1; i >= 0; i--)
        {
            Console.Write(cadena[i]);
        }

    }
}
