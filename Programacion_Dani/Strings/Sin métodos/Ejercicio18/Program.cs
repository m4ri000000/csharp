// (18) Dada una cadena de caracteres, determina la cantidad de minúsculas y mayúsculas que contiene la cadena. 
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
            int mayusculas = 0;
            int minusculas = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsUpper(cadena[i]))
                {
                    mayusculas++;
                }
                else if (char.IsLower(cadena[i]))
                {
                    minusculas++;
                }
            }
            Console.WriteLine("Mayúsculas: " + mayusculas);
            Console.WriteLine("Minúsculas: " + minusculas);
        }
    }
}