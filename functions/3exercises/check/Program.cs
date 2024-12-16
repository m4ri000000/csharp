using System;

class Program
{
    static void Main(string[] args)
    {
        double[] array = { 1.2, 2.3, 4.5, 6.7, 8.9, 6.4 };

        Console.WriteLine($"Suma de elementos: {SumarElementos(array)}");
        Console.WriteLine($"Promedio de elementos: {CalcularPromedio(array)}");
        Console.WriteLine($"Buscar elemento (2.3): {BuscarElemento(array, 2.3)}");

        double[] filtrados = FiltrarDatos(array, 4.5);
        Console.WriteLine($"Filtrados (mayores a 4.5): {string.Join(", ", filtrados)}");

        double[,] matriz = {
            { 1.1, 2.2, 3.3 },
            { 4.4, 5.5, 6.6 },
            { 7.7, 8.8, 9.9 }
        };

        double[,] trozo = RecortaMatriz(matriz, 1, 1, 2, 2);

        Console.WriteLine("Trozo de la matriz:");
        for (int i = 0; i < trozo.GetLength(0); i++)
        {
            for (int j = 0; j < trozo.GetLength(1); j++)
            {
                Console.Write($"{trozo[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static double SumarElementos(double[] array)
    {
        double suma = 0;
        for (int i = 0; i < array.Length; i++)
        {
            suma += array[i];
        }
        return suma;
    }

    static double CalcularPromedio(double[] array)
    {
        double suma = SumarElementos(array);
        return suma / array.Length;
    }

    static int BuscarElemento(double[] array, double valor)
    {
        for (int pos = 0; pos < array.Length; pos++)
        {
            if (array[pos] == valor)
            {
                return pos;
            }
        }
        return -1;
    }

    static double[] FiltrarDatos(double[] array, double limite)
    {
        int contador = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > limite)
            {
                contador++;
            }
        }

        double[] filtrados = new double[contador];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > limite)
            {
                filtrados[index] = array[i];
                index++;
            }
        }

        return filtrados;
    }

    static double[,] RecortaMatriz(double[,] matrizOriginal, int inicioFila, int inicioColumna, int filas, int columnas)
    {
        int maxFilas = matrizOriginal.GetLength(0);
        int maxColumnas = matrizOriginal.GetLength(1);

        filas = Math.Min(filas, maxFilas - inicioFila);
        columnas = Math.Min(columnas, maxColumnas - inicioColumna);

        double[,] trozo = new double[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                trozo[i, j] = matrizOriginal[inicioFila + i, inicioColumna + j];
            }
        }

        return trozo;
    }
}