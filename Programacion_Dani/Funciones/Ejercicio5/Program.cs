// (5) Comprobar si un número es primo -utilizando recursividad.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Introduce un número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Primo(num);
    }

    public static void Primo(int num)
    {
        if (num > 1)
        {
            bool esPrimo = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                }
            }
            if (esPrimo)
            {
                Console.WriteLine("El número es primo.");
            }
            else
            {
                Console.WriteLine("El número no es primo.");
            }
        }
        else
        {
            Console.WriteLine("El número debe ser mayor que 1.");
        }

    }
}