/*(6)  Escriba un programa que solicite 20 números enteros positivos, y los vaya insertando ordenados en un vector. 
Cada vez que insertamos un número, presentamos todos los elementos que ya hemos insertado hasta ese momento. */

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[20];
        int cantidadInsertada = 0;

        while (cantidadInsertada < 20)
        {
            Console.Write("Introduce un número entero positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                // Insertar el número en la posición correcta para mantener el arreglo ordenado
                int j = cantidadInsertada - 1;
                while (j >= 0 && numeros[j] > num)
                {
                    numeros[j + 1] = numeros[j];
                    j--;
                }
                numeros[j + 1] = num;
                cantidadInsertada++;

                // Mostrar los elementos insertados hasta el momento
                Console.Write("Elementos insertados hasta el momento:");
                for (int i = 0; i < cantidadInsertada; i++)
                {
                    Console.Write(numeros[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número entero positivo válido.");
            }
        }
    }
}