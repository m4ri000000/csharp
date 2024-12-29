//count occurences
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 2, 2, 3, 3, 3, 3};
        Console.Write("enter number to count: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        foreach(int num in nums)
        {
            if (num == number)
            {
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"the number {number} appears {count} times.");
        }
        else
        {
            Console.WriteLine("the number doesnt exist in the array.");
        }
    }
}