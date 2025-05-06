// (13) Programa que, dada una cadena de caracteres, elimine los caracteres en blanco a la izquierda de una cadena y la muestre por pantalla.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string? cadena;
        Console.Write("Introduce tu cadena: ");
        cadena = Console.ReadLine();
        int i = 0;
        while (i < cadena.Length && cadena[i] == ' ')
        {
            i++;
        }

        string resultado = "";
        for (; i < cadena.Length; i++)
        {
            resultado += cadena[i];
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}