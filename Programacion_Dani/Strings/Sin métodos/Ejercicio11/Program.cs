// (11) Introducir por teclado una frase y a continuación visualizar cada palabra de la frase, una debajo de otra, seguida cada palabra del número de letras que compone dicha palabra.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string? frase;
        Console.Write("Introduce tu frase: ");
        frase = Console.ReadLine();

        string palabra = "";
        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == ' ')
            {
                Console.WriteLine(palabra);
                Console.WriteLine("Número de letras: " + palabra.Length);
                palabra = "";
            }
            else
            {
                palabra += frase[i];
            }
        }

        Console.WriteLine(palabra);
        Console.WriteLine("Número de letras: " + palabra.Length);
    }
}