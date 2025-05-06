// (5) Dada una cadena por teclado, indicar cuáles son las vocales que contiene.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Introduce tu texto: ");
        string? cadena = Console.ReadLine();
        char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

        string? resultado = "";

        for (int i = 0; i < cadena?.Length; i++)
        {
            for (int j = 0; j < vocales.Length; j++)
            {
                if (cadena[i] == vocales[j])
                {
                    resultado += cadena[i];
                }
            }

        }

        Console.WriteLine($"Las vocales que contiene la cadena son: {resultado}");


    }
}