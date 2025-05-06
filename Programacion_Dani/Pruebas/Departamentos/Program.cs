using System;

public class Program
{
    // public static void Main(string[] args)
    // {
    //     // Ejemplo de uso
    //     double[,] ingresos = {
    //         { 100.50, 200.75, 300.60 },
    //         { 150.00, 250.50, 350.30 },
    //         { 120.25, 220.40, 320.10 }
    //     };

    //     // Mostrar la matriz
    //     Mostrar(ingresos);
    // }
    public static double[] Totales(double[,] ingresos)
    {
        double[] resultado = new double[ingresos.GetLength(1)];
        for (int columna = 0; columna < ingresos.GetLength(1); columna++)
        {
            for (int fila = 0; fila < ingresos.GetLength(0); fila++)
            {
                resultado[columna] += fila;
            }
        }
        return resultado;
    }

    public static void Mostrar(double[,] ingresos)
    {

        for (int fila = 0; fila < ingresos.GetLength(0); fila++)
        {
            Console.WriteLine(" ");
            for (int columna = 0; columna < ingresos.GetLength(1); columna++)
            {
                Console.Write($"{ingresos[fila, columna],6:0.00} ");
            }
        }
    }
}