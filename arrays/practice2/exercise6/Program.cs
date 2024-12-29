//pair with given sum
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        Console.Write("Enter the target sum: ");
        int target = Convert.ToInt32(Console.ReadLine());
        int i, j;
        bool found = false;
        Console.WriteLine("Pairs with target sum: ");
        for (i = 0; i < nums.Length; i++)
        {
            for (j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    Console.WriteLine($"{nums[i]}, {nums[j]}");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No pairs found that sum to the target.");
        }
    }
}