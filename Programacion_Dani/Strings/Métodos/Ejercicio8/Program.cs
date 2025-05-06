//  Escriba un programa para representar mediante barras de asteriscos 10 números
//  recogidos por teclado con valores enteros entre 1 y 20. Los 10 números se introducen
//  separados por un espacio mediante un string.
//  Por ejemplo:
//  Entrados los números:
//  1 8 3 14 5 10 7 11 9 10
//  el resultado es:
//  1 *
//  8 ********
//  3 ***
//  14 **************
//  5 *****
//  10 **********
//  7 *******
//  11 ***********
//  9 *********
//  10 **********

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese 10 números separados por un espacio:");
        string input = Console.ReadLine();
        string[] numeros = input.Split(' ');

        for (int i = 0; i < 10; i++)
        {
            int numero = Convert.ToInt32(numeros[i]);
            Console.Write($"{numero} ");
            for (int j = 0; j < numero; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}