//add 2 nums
using System;

class Program
{
    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result = Add(num1, num2);
        Console.WriteLine(result);
    }
}