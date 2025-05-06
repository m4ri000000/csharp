// (14) Dada una cadena de caracteres, elimina los caracteres en blanco a la derecha de la cadena y la muestre por pantalla. 

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
            int i = cadena.Length - 1;
            while (i >= 0 && cadena[i] == ' ')
            {
                i--;
            }
            string resultado = "";
            for (int j = 0; j <= i; j++)
            {
                resultado += cadena[j];
            }
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
