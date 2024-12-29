//reverse
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 4, 5};
        Array.Reverse(nums);
        Console.WriteLine("Reversed array: " + string.Join(", ", nums));
    }
}