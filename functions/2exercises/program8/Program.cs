/*Realizar una función a la que se le pasa un vector 
de números enteros (positivos y/o negativos), 
y devuelve el valor del número de menor valor de todos los incluidos */

using System;

class Program
{
    //funcion solicitada, busca el menor en un vector de numeros enteros
    //recibe un vector (int[] numeros) y una referencia a la variable menor (que aparecera en el main)
    static void ObtenerValorMenor(int[] numeros, ref int menor)
    {
        //verificamos que la tabla no sea null y que tenga al menos un elemento
        if (numeros != null && numeros.Length > 0)
        {
            //inicialiamos menor en la primera posicion (para que haga una busqueda)
            menor = numeros[0];

            //recorremos el vector con un foreach que buscara un num en cada elemento del vector
            foreach (int num in numeros)
            {
                //comparo cada valor con menor
                //si el valor es menor, actualizo menor
                if (num < menor)
                {
                    menor = num;
                }
            }
        }
        else
        {
            //asigno el valor minimo posible para indicar que no hay datos validos
            menor = int.MaxValue;
        }
    }

    static void Main()
    {
        int[] numeros = {1, 5, -4, -6, -7, 9, 8, -23, 1 };

        int menorValor = int.MaxValue; // variable para almacenar valor menor

        ObtenerValorMenor(numeros, ref menorValor);

        Console.WriteLine("El número de menor valor es: " + menorValor);
    }
}