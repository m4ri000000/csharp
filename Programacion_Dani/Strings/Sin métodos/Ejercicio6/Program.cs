// (6) Dada una cadena por teclado, contar el número de vocales que contiene.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Introduce tu texto: ");
        string? cadena = Console.ReadLine();
        char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

        int resultado = 0;

        for (int i = 0; i < cadena?.Length; i++)
        {
            for (int j = 0; j < vocales.Length; j++)
            {
                if (cadena[i] == vocales[j])
                {
                    resultado ++;
                }
            }

        }

        Console.WriteLine($"Hay un total de {resultado} vocales.");


    }
}