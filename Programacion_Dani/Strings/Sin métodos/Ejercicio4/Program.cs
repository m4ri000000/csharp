// (4) Dada una cadena por teclado, introducir en una nueva variable la cadena al revés, y mostrarla.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Escribe una frase: ");
        string? cadena = Console.ReadLine();

        // Invertir la cadena con un bucle creando una nueva string
        string cadenaInvertida = "";
        for (int i = cadena.Length - 1; i >= 0; i--)
        {
            cadenaInvertida += cadena[i];
        }

        Console.WriteLine($"Tu frase al revés: {cadenaInvertida}");
    }
}
