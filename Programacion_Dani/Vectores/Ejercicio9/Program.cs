// (9) Solicitar 10 números por teclado y mostrarlos de menor a mayor.

using System;

public class Program
{
    public static void Main()
    {
        int[] numeros = new int[10];
        int aux;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Introduce un número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (numeros[i] > numeros[j])
                {
                    aux = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = aux;
                }
            }
        }

        Console.WriteLine("Números ordenados de menor a mayor:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
