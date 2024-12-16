using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} es par.");
                // Coloca un breakpoint aquí para analizar la condición 'numero % 2 == 0'
            }
            else
            {
                Console.WriteLine($"{numero} es impar.");
                // Coloca otro breakpoint aquí para verificar el flujo alternativo
            }
        }
    }
}