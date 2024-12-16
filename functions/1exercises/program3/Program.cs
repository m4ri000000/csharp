using System;

class Program
{
    static void ContadorDeLetras(string input, char letra, out int contador)
    {
        contador = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if(input[i] == letra)
            {
                contador++;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Insertar cadena de caracteres: ");
        string input = Console.ReadLine();

        Console.Write("Insertar letra a contar: ");
        char letra = Console.ReadLine()[0];

        int cantidad;
        ContadorDeLetras(input, letra, out cantidad);

        Console.WriteLine($"La letra '{letra}' aparece {cantidad} veces en la cadena.");
    }
}