using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Valor máximo del cuadrado
        int max = 3;
        int[,] Cuadrado = new int[max, max];

        int fila = 0;
        int columna = max / 2;

        int o = 1;
        do
        {
            if (Cuadrado[Sig(fila, max), Sig(columna, max)] == 0)
            {
                fila = Sig(fila, max);
                columna = Sig(columna, max);
                // Console.WriteLine($"TEST: Fil {fila} Col {columna} Total {Cuadrado[fila, columna]}");
            }
            else if (Cuadrado[Sig(fila, max), Sig(columna, max)] != 0){
                int nuevaCol = columna - 1;
                if (nuevaCol >= max && nuevaCol < max)
                {
                    nuevaCol = 0;
                }

                columna = nuevaCol;
                // Console.WriteLine($"TEST ELSE: Fil {fila} Col {nuevaCol} Total {Cuadrado[fila, columna]}");
            }

            Cuadrado[fila, columna] = o;
            o++;
        } while (o <= max * max);

        // Imprimir el cuadrado mágico
        ImprimirCuadrado(Cuadrado);
    }

    public static int Sig(int i, int max)
    {
        max--;
        i++;
        if (i > max)
        {
            i = 0;
        }
        // Console.WriteLine($"TEST: {i}");
        return i;
    }

    public static void ImprimirCuadrado(int[,] cuadrado)
    {
        int filas = cuadrado.GetLength(0);
        int columnas = cuadrado.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"{cuadrado[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
