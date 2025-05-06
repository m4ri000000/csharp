// (9) Dados dos números, contar desde el primero al segundo número siempre que se pueda.
using System;

public class Program
{
    public static void Main()
    {
        int num1, num2;
        Console.Write("Introduce un número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce un número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("No se puede ;)")

        }
    }
}