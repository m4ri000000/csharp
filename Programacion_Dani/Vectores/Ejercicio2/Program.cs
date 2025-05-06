/* (2) Solicitar 1o números por teclado. A continuación, solicitar otro. 
Buscar ese último número entre los 10 primeros y decir, en el caso de que esté, en qué lugar fue introducido.*/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num, inc = 0, max = 10;
        int[] lista = new int[max];

        for (int i = 0; i < max; i++)
        {
            Console.Write("Introduce un número: ");
            lista[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Dame un número para comprobar si esta en la tabla: ");
        num = Convert.ToInt32(Console.ReadLine());
        while (inc < lista.Length - 1 && lista[inc] != num)
        {
            inc++;
        }
        if (lista[inc] == num) Console.WriteLine("Si");
        else Console.WriteLine("No");

    }
}