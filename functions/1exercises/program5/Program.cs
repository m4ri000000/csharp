using System;

class Program
{
    static void EsPrimo(int numero, out bool esPrimo)
    {
        esPrimo = true; 

        if (numero <= 1) 
        {
            esPrimo = false; 
            return;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++) 
        {
            if (numero % i == 0)
            {
                esPrimo = false; 
                return;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("introduce un número para comprobar si es primo: ");
        int numero = int.Parse(Console.ReadLine());

        bool esPrimo;
        EsPrimo(numero, out esPrimo);

        if (esPrimo)
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número primo.");
        }
    }
}