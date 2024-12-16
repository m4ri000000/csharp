using System;

class Program
{
    static void Main()
    {
        string input;
        string reversed = "";

        Console.WriteLine("insert sentence to flip: ");
        input = Console.ReadLine();

        for (int i = input.Length - 1; i>=0; i--)
        {
            reversed += input[i];
        }
        /*input.Length - 1 me hace empezar el bucle en el ultimo caracter de la cadena.
        i >= 0, hace que las iteraciones que empiezan en el ultimo caracter sigan
        mientras que este sea mayor o igual a 0 (no solo > porque el primer caracter se encuentra
        en la posicion 0)
        i-- me permite recorrer el bucle hacia atras
        reversed + input[i], siendo que reversed es vacio, le añado la letra que encuentro en
        cada posicion i en cada iteracion para obtener la nueva cadena reversed.*/

        Console.WriteLine($"the flipped sentence is {reversed}.");
    }
}
