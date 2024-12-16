/*Realizar una función a la que se le pasa un vector de números enteros (positivos y/o negativos), 
y devuelve la posición del número de menor valor de todos los incluidos.*/
using System;
class Program
{
    static int ObtenerPosicionValorMenor(int[] numeros)
    {
        int posicion = 0;
        int menor = numeros[0];

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
                posicion = i;
            }
        }
        return posicion;
    }

    static void Main()
    {
        int[] numeros = {1, -50, -4, -6, -7, 9, 8, 1 };

        int posicion = ObtenerPosicionValorMenor(numeros);

        Console.WriteLine($"la posicion del numero minimo es: {posicion + 1} ");
    }

}