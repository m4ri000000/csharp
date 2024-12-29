using System;

class Program
{
    static int SumArray(int[] array)
    {
        int sum = 0;
        foreach(int n in array)
        {
            sum += n;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        int[] numbers = {10, 20, 30, 30, 60, 80};
        int sum = SumArray(numbers);
        Console.WriteLine($"The sum of the array is {sum}.");
    }
}