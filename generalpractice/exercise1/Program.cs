/*implementa un programa Secuencias que lea de teclado 20 numeros enteros (distintos de 0)
una vez leidos, los muestra por la salida estandar
comenzando con una nueva linea cada vez que la secuencia de numeros (en valor absoluto) sume mas de 100
al final de cada linea debe mostrarse (entre barras) la suma absoluta de la linea*/
using System;
class Program
{
    static void Main()
    {
        int[] numeros = LeerNumeros(20);
        MostrarSecuencias(numeros);
    }

    static int[] LeerNumeros(int cantidad)
    {
        int[] numeros = new int[cantidad];
        Console.WriteLine($"introduce {cantidad} enteros (distintos de 0): ");

        for (int i = 0; i < cantidad; i++)
        {
            int numero;
            do
            {
                Console.Write($"numero {i + 1}: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero == 0);

            numeros[i] = numero;
        }

        return numeros;
    }

    static void MostrarSecuencias(int[] numeros)
    {
        int suma = 0;
        Console.WriteLine("\nSecuencias:");
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += Math.Abs(numeros[i]);

            Console.Write(numeros[i] + " ");

            if (suma > 100 || i == numeros.Length - 1)
            {
                Console.WriteLine($"| {suma} |");
                suma = 0;
            }
        }
    }
}