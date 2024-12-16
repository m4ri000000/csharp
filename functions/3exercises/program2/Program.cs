//Escribe una función que calcule el promedio de un array de números doubles
using System;
class Program
{
    static double CalcularPromedio(double[] array)
    {
        double suma = 0;
        int i = 0;

        for (i = 0; i < array.Length; i++)
        {
            suma += array[i];
        }
        
        double promedio = suma / array.Length;
        return promedio;
    }
}