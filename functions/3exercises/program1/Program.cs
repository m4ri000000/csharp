/* Desarrolla una función que reciba un array de números doubles 
y devuelva la suma de todos los elementos.*/

using System;
class Program
{
    static double SumarElementos(double[] array)
    {
        double suma = 0;
        int i = 0;

        for (i = 0; i < array.Length; i++)
        {
            suma += array[i];
        }

        return suma;
    }
}