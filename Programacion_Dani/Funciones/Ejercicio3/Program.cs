// (3) Realizar una función a la que se le pasa una cadena de caracteres y una letra y devuelve la cantidad de veces que aparece esta letra en la cadena.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string cadena;
        char caracter;

        Console.Write("Dame una cadena por teclado: ");

        cadena = Console.ReadLine();

        Console.Write("Dame una letra por teclado: ");

        caracter = Console.ReadKey().KeyChar;

        Console.WriteLine($"\nSe ha repetido {Consulta(cadena, caracter)} la letra {caracter} en la cadena {cadena}");

    }

    private static int Consulta(string cadena, char letra)
    {

        int contador = 0;
        foreach (char caracter in cadena)
        {
            if (caracter == letra)
            {
                contador ++;
            }
        }

        return contador;
    }
}