// (10) Escriba un programa que pida dos números enteros y escriba la suma de todos los enteros desde el primer número hasta el segundo.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num1, num2, suma = 0;
        Console.Write("Dame un número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dame otro número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        for (int i = num1; i <= num2; i++)
        {
            suma += i;
        }

        Console.Write($"Dejame entregar {suma}");
    }
}