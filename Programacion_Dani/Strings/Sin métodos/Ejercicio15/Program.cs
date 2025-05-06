// (15) Dada una cadena de caracteres, elimina los espacios en blanco a ambos extremos de la cadena y la muestra por pantalla. 

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
            while (i < cadena.Length && cadena[i] == ' ')
            {
                i++;
            }
            int j = cadena.Length - 1;
            while (j >= 0 && cadena[j] == ' ')
            {
                j--;
            }
            string resultado = "";
            for (int k = i; k <= j; k++)
            {
                resultado += cadena[k];
            }
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}