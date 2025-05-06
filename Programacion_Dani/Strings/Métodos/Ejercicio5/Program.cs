// Dada una cadena de caracteres, elimina los espacios en blanco a ambos extremos de la cadena y la muestra por pantalla.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string cadena;
        Console.Write("Coloca tu frase: ");
        cadena = Console.ReadLine();
        Console.WriteLine(cadena.Trim());
    }
}