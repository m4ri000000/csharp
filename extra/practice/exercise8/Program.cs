using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[20];
        int i = 0;
        Console.WriteLine("introduce 20 numeros enteros, positivos y negativos: ");
        for (i = 0; i < 20; i++)
        {
            Console.Write($"numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        string positivos = "";
        string negativos = "";
        int contadorPos = 0;
        int contadorNeg = 0;

        foreach (int numero in numeros)
        {
            if (numero > 0)
            {
                positivos += numero + " ";
                contadorPos++;
            }
            else if (numero < 0)
            {
                negativos += numero + " ";
                contadorNeg++;
            }
        }

        Console.WriteLine("\nnumeros positivos: ");
        Console.WriteLine($"{positivos} | Cantidad: {contadorPos}");

        Console.WriteLine("\nnumeros negativos: ");
        Console.WriteLine($"{negativos} | Cantidad: {contadorNeg}");
    }
}