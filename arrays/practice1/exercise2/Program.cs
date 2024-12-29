using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        bool encontrado = false;
        int indice = -1;

        Console.WriteLine("Introduce 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Introduce un número para buscar: ");
        int numeroBuscado = Convert.ToInt32(Console.ReadLine());

        // Búsqueda sin usar break, se indica el índice cuando se encuentra el número
        int iBusqueda = 0;
        while (iBusqueda < 10 && !encontrado)
        {
            if (numeros[iBusqueda] == numeroBuscado)
            {
                indice = iBusqueda;
                encontrado = true;
            }
            iBusqueda++;
        }

        if (encontrado)
        {
            Console.WriteLine($"El número {numeroBuscado} fue introducido en la posición {indice + 1}");
        }
        else
        {
            Console.WriteLine("El número no se encuentra en los 10 primeros.");
        }
    }
}