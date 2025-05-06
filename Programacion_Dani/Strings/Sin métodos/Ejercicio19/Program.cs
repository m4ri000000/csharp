// (19) Calcula la cantidad de veces que se repite un carácter dado en una cadena. 

using System;


public class Program
{
    public static void Main(string[] args)
    {
        string? cadena;
        char caracter;
        Console.Write("Introduce tu cadena: ");
        cadena = Console.ReadLine();
        Console.Write("Introduce el caracter a buscar: ");
        caracter = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (cadena != null)
        {
            int contador = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == caracter)
                {
                    contador++;
                }
            }
            Console.WriteLine("El caracter '" + caracter + "' se repite " + contador + " veces.");
        }
    }
}