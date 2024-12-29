//sum of array elements
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {2, 2, 2, 2};
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"the sum is {sum}.");
    }
}