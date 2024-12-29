using System;
class Program
{
    static int FindMaximum(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    static void Main()
    {
        Console.WriteLine("enter three numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int max = FindMaximum(num1, num2, num3);

        Console.WriteLine($"the largest number is {max}.");
    }
}