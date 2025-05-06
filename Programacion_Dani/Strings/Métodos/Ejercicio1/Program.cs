// Dada una cadena por teclado, indicar cuáles son las vocales que contiene.
using System;

class Program
{
    static void Main()
    {
        // Pedir al usuario que ingrese una cadena de texto
        Console.WriteLine("Ingresa una cadena de texto:");
        string input = Console.ReadLine();

        // Definir las vocales
        string vocales = "aeiouAEIOU";

        // Usamos un string para almacenar las vocales encontradas (sin duplicados)
        string vocalesEncontradas = "";

        // Recorrer la cadena usando un bucle for
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            // Verificar si el carácter es una vocal y si no ha sido registrada antes
            if (vocales.Contains(c) && !vocalesEncontradas.Contains(c))
            {
                vocalesEncontradas += c;
            }
        }


        Console.WriteLine("Vocales encontradas: ");
        Console.WriteLine(vocalesEncontradas);
    }
}
