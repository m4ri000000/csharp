/* Desarrolla una función que tome un array de números doubles y un valor límite, 
y devuelva un nuevo array con solo aquellos elementos que son mayores al valor límite.*/
using System;
class Program 
{
    double[] FiltrarDatos (double[] array, int limite)
    {
        int contador = 0;
        int i = 0;
        for (i < 0; i < array.Length; i++)
        {
            if(array[i] > limite)
            {
                contador++;
            }
        }

        double[] filtrados = new double[contador];

        int index = 0;
        for (i = 0; i < array.Length; i++)
        {
            if(array[i] > limite) //guarda las posiciones de los valores mayores del limite
            {
                filtrados[index] = array[i]; //los guardo en el nuevo array
                index++; //incremento el indice para seguir buscando
            }
        }

        return filtrados;
    }
}