//check even or odd
using System;

class Program
{
    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isEven = IsEven(num);
        Console.WriteLine(isEven);
    }
}