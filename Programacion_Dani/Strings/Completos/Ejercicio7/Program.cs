/*(7) Realizar el algoritmo que, solicitada una cantidad de elementos de un vector, y el límite 
superior e inferior de los datos a calcular, rellenar con elementos aleatorios dentro de los límites 
pedidos dicho vector y lo presente por pantalla. A continuación, pida por teclado un nuevo valor  
que debe cumplir las mismas condiciones de los anteriores y una posición que debe estar dentro 
de los límites del vector inicial. Crear un nuevo vector que contenga la información del vector 
inicial pero insertando el valor pedido en la posición pedida. Finalmente, mostrar ambos 
vectores al final. 
Solicita el número de posiciones iniciales: 15 
Límite inferior: 2 
Límite superior:10 
Vector inicial: 5 4 3 5 2 9 4 8 10 3 5 6 4 2 4 
Dato nuevo: 5 
Posición: 7 
Vector inicial: 5 4 3 5 2 9 4 8 10 3 5 6 4 2 4 
Vector final: 5 4 3 5 2 9 5 4 8 10 3 5 6 4 2 4*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int valor, max, min;

        Console.Write("Introduce el número de posiciones iniciales del vector: ");
        valor = Convert.ToInt32(Console.ReadLine());

        int[] vectorI = new int[valor];
        Random rnd = new Random();

        Console.Write("Introduce el límite superior: ");
        max = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el límite inferior: ");
        min = Convert.ToInt32(Console.ReadLine());

        // Rellenar vectorI con valores aleatorios dentro de los límites
        for (int i = 0; i < valor; i++)
        {
            vectorI[i] = rnd.Next(min, max + 1);
        }

        // Mostrar el vector inicial
        Console.WriteLine("\nVector inicial:");
        foreach (int num in vectorI)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();

        // Pedir un nuevo valor dentro de los mismos límites
        int numNuevo;
        do
        {
            Console.Write("Introduce un nuevo valor dentro de los límites: ");
            numNuevo = Convert.ToInt32(Console.ReadLine());
        } while (numNuevo < min || numNuevo > max);

        // Pedir la posición en la que se quiere insertar el nuevo valor
        int pos;
        do
        {
            Console.Write("Introduce la posición donde quieres modificarlo (0 a {0}): ", valor - 1);
            pos = Convert.ToInt32(Console.ReadLine());
        } while (pos < 0 || pos >= valor);

        // Crear vectorF como copia de vectorI
        int[] vectorF = new int[valor];
        Array.Copy(vectorI, vectorF, valor);

        // Insertar el nuevo valor en la posición indicada
        vectorF[pos] = numNuevo;

        // Mostrar ambos vectores
        Console.WriteLine("\nVector inicial:");
        foreach (int num in vectorI)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine("\nVector final:");
        foreach (int num in vectorF)
        {
            Console.Write($"{num} ");
        }
    }
}
