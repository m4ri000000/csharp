/*programa secuencias
lee de teclado 20 numeros enteros
comienza una nueva linea cada vez que la suma de los numeros (en valor abs) sume mas de 100
al final de cada linea se muestra entre barras | | la suma absoluta de la linea*/
using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[20]; //lee de teclado 20 numeros
        int i;
        int sumaAbs = 0;
        int numAbs;

        Console.WriteLine("introducir 20 numeros enteros: "); //solicito los numeros
        for (i = 0; i < 20; i++) //abro el bucle for que solicitará los 20 numeros 
        {
            while (numeros[i] != 0)
            {
                Console.Write($"numero {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }

        for (i = 0; i < 20; i++)
        {
            numAbs = Math.Abs(numeros[i]);
            sumaAbs += numAbs;

            Console.Write($"{numeros[i]} ");

            if (sumaAbs > 100 || i == 19)
            {
                Console.Write($"\\{sumaAbs}\\");
                Console.WriteLine();
                sumaAbs = 0;
            }
        }

    }
}
