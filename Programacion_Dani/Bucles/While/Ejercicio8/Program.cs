// (8) Imprimir y contar el número de múltiplos de tres que existen desde el 1 a un número solicitado por teclado.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num, i = 1;
        Console.Write("Ingresa un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Múltiplos de tres desde 1 hasta " + num + ":");
        while (i <= num)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

    }
}