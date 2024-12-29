//Fibonacci sequence
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("introduce el numero de fibonacci: ");
        int n = int.Parse(Console.ReadLine());
        GenerateFibonacci(n);
    }

    static void GenerateFibonacci(int n)
    {
        int a = 0; 
        int b = 1;
        int i;
        int temp;

        Console.WriteLine("Fibonacci sequence:");
        for (i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            temp = a;
            a = b;
            b = temp + b;
        }
    }
}