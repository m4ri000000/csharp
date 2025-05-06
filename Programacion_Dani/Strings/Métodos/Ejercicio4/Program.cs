// Introducir por teclado una frase y a continuación visualizar cada palabra de la frase, una debajo de otra, seguida cada palabra del número de letras que compone dicha palabra.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string cadena;
        Console.Write("Coloca tu frase: ");
        cadena = Console.ReadLine();
        string[] palabras = cadena.Split(" ");
        for (int i = 0; i < palabras.Length; i++)
        {
            Console.WriteLine(palabras[i]);
            Console.WriteLine(palabras[i].Length);
        }
    }
}