using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[20];
        int i = 0;
        Console.WriteLine("introducir 20 numeros (distintos de 0): ");
        for (i = 0; i < 20; i++)
        {
            Console.Write($"numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int sumaAbs = 0;

        for (i = 0; i < 20; i++)
        {
            int numAbs = Math.Abs(numeros[i]);
            sumaAbs += numAbs;
            Console.Write($"{numeros[i]} ");
            if (sumaAbs > 100 || i == 19)
            {
                Console.Write($"|{sumaAbs}|");
                Console.WriteLine();
                sumaAbs = 0;
            }
        }
    }
}