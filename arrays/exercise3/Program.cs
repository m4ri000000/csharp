//10 numeros por teclado que hay que mostrar
using System;
class Program
{
    static void Main()
    {
        //fase declarativa 
        int[] numeros = new int[10]; //patron para cuando me solicitan un array de determinadas dimensiones
        int i;
        bool esValido = false;

        //como solicitar una cantidad de numeros
        Console.WriteLine("introduce 10 numeros: ");
        for (i = 0; i < 10; i++)
        {
            while (!esValido)
            {
                Console.Write($"numero {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                esValido = true;
            }
            esValido = false;
        }

        //como imprimirlos (imprimo el array)
        Console.WriteLine("\nLos numeros impresos son:");
        for (i = 0; i < 10; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}