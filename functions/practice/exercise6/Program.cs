using System;
class Program
{
    static int CalculoPromedioRedondeado(int[] numeros)
    {
        int suma = 0;
        foreach(int numero in numeros)
        {
            suma += numero;
        }

        double promedio = (double)suma / numeros.Length;
        return (int)Math.Round(promedio / 5.0) * 5;
    }

    static void Main()
    {
        Console.Write("introduce cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int [cantidad];
        int suma = 0;

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"introduce numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros [i];
        }

        int promedioRedondeado = CalculoPromedioRedondeado(numeros);
        Console.WriteLine($"promedio ajustado: {promedioRedondeado}");
    }
}