using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20, 25 };
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        double promedio = (double)suma / numeros.Length;
        Console.WriteLine($"El promedio es: {promedio}");
    }
}
