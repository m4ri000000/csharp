/*Realizar una función a la que se le pasa el número de elementos 
con el que se rellena un vector con números aleatorios entre el 1 y el 99.*/

using System;
class Program
{
    static int[] Rellena(int numeroElementos)
    {
        int[] vector = new int[numeroElementos];

        Random random = new Random(); //Random se podrá usar?

        for (int i = 0; i < numeroElementos; i++)
        {
            vector[i] = random.Next(1, 100);
        }
        return vector;
    }

    static void Main()
    {
        int numeroElementos = 30;
        int[] vector = Rellena(numeroElementos);
        Imprime(vector);
    }

    static void Imprime(int[] vector)
    {
        Console.WriteLine("vector rellenado: ");
        foreach (int num in vector)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}