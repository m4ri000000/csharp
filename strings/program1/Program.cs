using System;

class Program
{
    static void Main()
    {
        string input;
        int counter = 0;
        int index = 0;

        Console.WriteLine("insert chain: ");
        input = Console.ReadLine();

        while (index < input.Length)
        {
            counter++;
            index++;
        }
        Console.WriteLine($"chain has {counter} characters.");
    }
}