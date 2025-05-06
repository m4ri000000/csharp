// (10) Dados dos números introducidos por teclado, mostrar los números naturales que hay entre ambos.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        bool mayor = num1 > num2;

        if (mayor)
        {
            int i = num2;
            while (i < num1)
            {
                Console.Write(i + " ");
                i++;
            }
        }
        else
        {
            int i = num1;
            while (i < num2)
            {
                Console.Write(i + " ");
                i++;
            }
        }
    }
}
