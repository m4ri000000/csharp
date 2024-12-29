//find the smallest element
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 4, 5};
        int smallest = nums[0];
        foreach(int num in nums)
        {
            if (num < smallest)
            {
                smallest = num;
            }
        }
        Console.WriteLine($"The smallest number is {smallest}.");
    }
}