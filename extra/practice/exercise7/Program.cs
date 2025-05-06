using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[15];
        int i = 0; 
        Console.WriteLine("escribe 15 numeros (distintos de 0): ");
        for (i = 0; i < 15; i++)
        {
            Console.Write($"numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int sumaAbs = 0;

        for (i = 0; i < 15; i++)
        {
            int numAbs = Math.Abs(numeros[i]);
            sumaAbs += numAbs;
            Console.Write($"{numeros[i]} ");
            if (sumaAbs > 50 || i == 14)
            {
                Console.Write($"|{sumaAbs}|");
                Console.WriteLine();
                sumaAbs = 0;
            }
        }
    }
}