/* (16) Un palíndromo es una palabra que se lee igual hacia adelante que hacia atrás. 
Dada una cadena de caracteres por teclado, mostrar si la cadena es un palíndromo o no. */
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string? cadena;
        Console.Write("Introduce tu cadena: ");
        cadena = Console.ReadLine();

        if (cadena != null)
        {
            int i = 0;
            int j = cadena.Length - 1;
            bool esPalindromo = true;

            while (i < j && esPalindromo)
            {
                if (cadena[i] != cadena[j])
                {
                    esPalindromo = false;
                }
                i++;
                j--;
            }

            if (esPalindromo)
            {
                Console.WriteLine("La cadena es un palíndromo.");
            }
            else
            {
                Console.WriteLine("La cadena no es un palíndromo.");
            }
        }
    }
}