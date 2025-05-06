/*(17) Un número capicúo se refiere a cualquier número que se lee igual de izquierda a derecha y de derecha a izquierda. 
Dado un número por teclado, devolver si se trata de un capicúo o no. */

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string? numero;
        Console.Write("Introduce tu número: ");
        numero = Console.ReadLine();

        if (numero != null)
        {
            int i = 0;
            int j = numero.Length - 1;
            bool esCapicuo = true;
            while (i < j && esCapicuo)
            {
                if (numero[i] != numero[j])
                {
                    esCapicuo = false;
                }
                i++;
                j--;
            }
            if (esCapicuo)
            {
                Console.WriteLine("El número es capicúo.");
            }
            else
            {
                Console.WriteLine("El número no es capicúo.");
            }
        }
    }
}