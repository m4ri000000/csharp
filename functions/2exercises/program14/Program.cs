/* contar ocurrencias de un caracter en un string
imprimir sus posiciones*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("introducir texto: ");
        string input = Console.ReadLine();

        Console.WriteLine("caracter a buscar: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        int[] posiciones;
        int cantidadOcurrencias = ContarCaracter(input, c, out posiciones);

        Console.WriteLine($"el caracter {c} aparece {cantidadOcurrencias} veces en el string {input}");
        Console.WriteLine("Posiciones: " + string.Join(", ", posiciones));
    }

    static int ContarCaracter(string input, char c, out int[] posiciones)
    {
        int contador = 0;
        int indice = 0;
        posiciones = new int[input.Length]; //maximo posiciones posibles (tienen q estar dentro del input)

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == c)
            {
                posiciones[indice] = i;
                indice++;
                contador++;
            }
        }

        Array.Resize(ref posiciones, contador);
        return contador;
    }
}