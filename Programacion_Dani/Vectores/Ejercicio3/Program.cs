// (3) Solicitar 10 números distintos por teclado y mostrarlos.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] lista = new int[10];
        for (int i = 0; i < 10; i++)
        {
            int numero;
            bool esDistinto;
            do
            {
                esDistinto = true;
                Console.Write("Dame un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                // Verificar si el número ya está en la lista
                for (int j = 0; j < i; j++)
                {
                    if (lista[j] == numero)
                    {
                        esDistinto = false;
                        Console.WriteLine("El número ya ha sido ingresado. Intenta con otro número.");
                    }
                }
            } while (!esDistinto);

            lista[i] = numero;
        }

        Console.WriteLine("Números ingresados:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($" {lista[i]}");
        }
    }
}