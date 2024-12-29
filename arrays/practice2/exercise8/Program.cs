//count positive, negative and zero elements
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, -1, 2, -2, 3, 4, -5, 0, -7, 0};
        int posCount = 0, negCount = 0, zeroCount = 0;
        foreach(int num in nums)
        {
            if (num > 0)
                posCount++;
            else if (num < 0)
                negCount++;
            else
                zeroCount++;
        }
        Console.WriteLine($"The amount of positive numbers is {posCount}.");
        Console.WriteLine($"The amount of negative numbers is {negCount}.");
        Console.WriteLine($"The amount of zeros is {zeroCount}.");
    }
}