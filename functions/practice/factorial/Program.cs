//calculate factorial
using System;

class Program
{
    static int Factorial(int n)
    {
        int res = 1;
        int i;
        for (i = 1; i <= n; i++)
        {
            res *= i;
        }
        return res;
    }
    static void Main(string[] args)
    {
        int fact = Factorial(9);
        Console.WriteLine(fact);
    }
}