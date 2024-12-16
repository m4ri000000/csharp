/*Escribe una función en C# que tome como parámetros una matriz bidimensional 
de números doubles, las coordenadas de inicio (fila, columna) 
y el tamaño del trozo (filas, columnas), y devuelva una nueva matriz 
que represente el trozo acotado por las coordenadas indicadas de la matriz original.
Asegúrate de gestionar adecuadamente los casos en los que las coordenadas de inicio 
y el tamaño del trozo excedan las dimensiones de la matriz original*/

using System;

class Program
{
    static double[,] RecortaMatriz(double[,] matrizOriginal, int inicioFila, int inicioColumna, int filas, int columnas)
    {
        int maxFilas = matrizOriginal.GetLength(0);
        int maxColumnas = matrizOriginal.GetLength(1);
        int i = 0;
        int j = 0;

        //no exceder los limites originales

        filas = Math.Min(filas, maxFilas - inicioFila); //me aseguro no exceder el limite desde inicio fila
        columnas = Math.Min(columnas, maxColumnas - inicioColumna);

        //crear la matriz cortada

        double[,] trozo = new double[filas, columnas];

        for (i = 0; i < filas; i++)
        {
            for (j = 0; j < columnas; j++)
            {
                trozo[i, j] = matrizOriginal[inicioFila + i, inicioColumna + j];
            }
        }

        return trozo;
    }
}
