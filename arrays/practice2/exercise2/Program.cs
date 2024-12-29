//find the largest element
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 2, 1};
        int largest = nums[0];
        foreach(int num in nums)
        {
            if(num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"the largest element is: {largest}.");
    }
}