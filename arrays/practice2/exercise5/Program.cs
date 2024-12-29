//find even num
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] evenNums = Array.FindAll(nums, nums => nums % 2 == 0);
        Console.WriteLine("even numbers: " + string.Join(", ", evenNums));
    }
}