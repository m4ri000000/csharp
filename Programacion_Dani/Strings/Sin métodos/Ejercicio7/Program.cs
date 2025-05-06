// (7) Dada una cadena por teclado, y una segunda de comparación, mostrar por pantalla la cadena “Está” cuando encontremos la segunda cadena en cualquier posición de la primera.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string? frase, palabra;
        Console.Write("Introduce tu primera cadena: ");
        frase = Console.ReadLine();
        Console.Write("Introduce tu segunda cadena: ");
        palabra = Console.ReadLine();

        bool encontrada;

        int frase_longitud = frase.Length;
        int palabra_longitud = palabra.Length;

        int i = 0;
        do
        {
            int j = 0;

            // Compara cada carácter de palabra con el subsegmento de frase
            while (j < palabra_longitud && frase[i + j] == palabra[j])
            {
                j++;
            }

            i++;

            // Si j llega al final de palabra, significa que todas las letras coincidieron
            encontrada = (j == palabra_longitud);
        } while (i <= frase_longitud - palabra_longitud && !encontrada);

        if (encontrada)
        {
            Console.WriteLine("Está");
        }
        else
        {
            Console.WriteLine("No está");
        }
    }
}
