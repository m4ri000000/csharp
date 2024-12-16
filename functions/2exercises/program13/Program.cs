/*Realizar una función que, pasado un vector del que desconocemos su longitud, 
calcule la media de sus valores (no se utilizan funciones de cálculo). 
Utilizar la función del ejercicio 4 para rellenar los valores para implementar la prueba de tu función.*/

using System;

class Program
{
    static int[] Rellena(int numeroElementos)
    {
        int[] vector = new int[numeroElementos];

        Random random = new Random();

        for (int i = 0; i < numeroElementos; i++)
        {
            vector[i] = random.Next(1, 100); // Valores entre 1 y 99
        }

        return vector;
    }

    static double CalcularMedia(int[] vector)
    {
        int suma = 0;
        
        for (int i = 0; i < vector.Length; i++)
        {
            suma += vector[i];
        }

        return (double)suma / vector.Length;
    }

    static void Main()
    {
        int numeroElementos = 20;

        int[]vector = Rellena(numeroElementos);

        Console.WriteLine(string.Join(" - ", vector));

        double media = CalcularMedia(vector);
        Console.WriteLine($"la media del vector es: {media}");
    }
}