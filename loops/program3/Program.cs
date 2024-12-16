//bucles anidados
using System;
class Program
{
    static void Main()
    {
        int i;
        int j;
        for (i = 1; i <= 10; i++) //numeros del 1 al 10
        {
            Console.WriteLine($"Tabla del {i}:");
            Console.WriteLine();
            for (j = 1; j <= 12; j++) //numeros del 1 al 12
            {
                Console.WriteLine($"{i} x {j} = {i * j}"); //operacion que quiero realizar 
            }
            Console.WriteLine(); //salto de linea al final de cada tabla
        } 
    }
}