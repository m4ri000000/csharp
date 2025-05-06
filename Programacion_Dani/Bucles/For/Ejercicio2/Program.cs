// (2) Pide por teclado cinco números y muestra su suma.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
        {
            int num;
            Console.Write("Introduce un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            suma += num;
        }

        Console.WriteLine("La suma de los números es: " + suma);
    }
}