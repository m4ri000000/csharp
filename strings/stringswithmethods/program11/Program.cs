using System;

class Program
{
    static void Main()
    {
        double[] numbers = new double[10];
        double sum = 0;

        Console.WriteLine("enter 10 decimal numbers");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"enter number {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
            sum += numbers[i];
        }

        double average = sum / 10;

        Console.WriteLine($"\nthe average is: {average}");

        Console.WriteLine("\nthe numbers above average are:");
        for (int i = 0; i < 10; i++)
        {
            if (numbers[i] > average)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}