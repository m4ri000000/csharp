// Dada una cadena por teclado, y una segunda de comparación, mostrar por pantalla la cadena “Está” cuando encontremos la segunda cadena en cualquier posición de la primera

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string? cadena, palabra;

        Console.Write("Coloca tu frase: ");
        cadena = Console.ReadLine();

        Console.Write("¿Qué quieres buscar? ");
        palabra = Console.ReadLine();

        if (cadena.Contains(palabra))
        {
            Console.WriteLine("Está!");
        }
        else Console.WriteLine("NO Está!");


    }
}