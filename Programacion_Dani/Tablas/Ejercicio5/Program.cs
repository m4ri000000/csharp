/* Escribe una función en C# que tome como parámetros una matriz bidimensional de números doubles, las coordenadas de inicio (fila, columna) y el tamaño del trozo (filas, columnas), y devuelva una nueva matriz que represente el trozo acotado por las coordenadas indicadas de la matriz original.
Asegúrate de gestionar adecuadamente los casos en los que las coordenadas de inicio y el tamaño del trozo excedan las dimensiones de la matriz original.*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int filas;
        int columnas;

        Console.WriteLine("¿Cuantas columnas tendrá tu matríz?");
        columnas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("¿Cuantas filas tendrá tu matríz?");
        filas = Convert.ToInt32(Console.ReadLine());

        // Crear matríz de manera aleatoria e imprimirla

        Random randomIncrementoCol = new Random();
        Random randomIncrementoFil = new Random();
        int incrementoCol = randomIncrementoCol.Next(1, 20);
        int incrementoFil = randomIncrementoFil.Next(1, 20);

        // Generar un valor random para el tamaño de la matríz
        Random randomColumnas = new Random();
        int numeroColumnas = randomColumnas.Next(columnas, columnas + incrementoCol);
        Random randomFilas = new Random();
        int numeroFilas = randomFilas.Next(filas, filas + incrementoFil);

        Console.WriteLine($"Se va a generar una matriz de {numeroFilas} filas y {numeroColumnas} columnas");

        double[,] matriz = new double[numeroFilas, numeroColumnas];
        Random random = new Random();
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = random.Next(0, 100);
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

    public static double[,] RecortaMatriz(double[,] matrizOriginal, int inicioFila, int inicioColumna, int filas, int columnas) {
        double[,] matrizRecortada = new double[filas, columnas];
        int filasMatrizOriginal = matrizOriginal.GetLength(0);
        int columnasMatrizOriginal = matrizOriginal.GetLength(1);

        if (inicioFila + filas > filasMatrizOriginal || inicioColumna + columnas > columnasMatrizOriginal) {
            Console.WriteLine("Las coordenadas de inicio y el tamaño del trozo exceden las dimensiones de la matriz original");
            return null;
        }

        for (int i = inicioFila; i < filas; i++) {
            for (int j = inicioColumna; j < columnas; j++) {
                matrizRecortada[i - inicioFila, j - inicioColumna] = matrizOriginal[i, j];
            }
        }

        return matrizRecortada;
     }
}