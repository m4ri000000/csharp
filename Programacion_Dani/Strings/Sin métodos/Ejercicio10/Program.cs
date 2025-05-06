/*(10) Dada una frase y una palabra, eliminar esa palabra de la frase tantas veces como aparezca, diciendo la frase sin ellas y el número de veces que se ha eliminado. 

Por ejemplo: 
dada la frase: “Hola amigo. Como estas amigo. Yo estoy muy bien amigo.”, y la palabra “amigo”, debe devolver: “Hola. Como estas. Yo estoy muy bien.” y mostrar el valor 3, por eliminarlo tres veces. Se debe eliminar la palabra, y el espacio en blanco anterior si lo hubiera.*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string? frase, palabra;
        Console.Write("Introduce tu frase: ");
        frase = Console.ReadLine();
        Console.Write("Introduce tu palabra: ");
        palabra = Console.ReadLine();

        int contador = 0;
        string resultado = "";
        int palabraLength = palabra.Length;

        for (int i = 0; i < frase.Length; i++)
        {
            bool match = true;
            int j = 0;

            // Verificar si la palabra coincide en la posición actual
            do
            {
                if (i + j >= frase.Length || frase[i + j] != palabra[j])
                {
                    match = false;
                }
                j++;
            } while (match && j < palabraLength);

            if (match)
            {
                contador++;

                // Eliminar el espacio en blanco anterior si lo hubiera
                if (resultado.Length > 0 && resultado[resultado.Length - 1] == ' ')
                {
                    string temp = "";
                    for (int k = 0; k < resultado.Length - 1; k++)
                    {
                        temp += resultado[k];
                    }
                    resultado = temp;
                }

                i += palabraLength - 1;
            }
            else
            {
                resultado += frase[i];
            }
        }

        Console.WriteLine("Frase resultante: " + resultado);
        Console.WriteLine("Número de veces eliminada: " + contador);
    }
}