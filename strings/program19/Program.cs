using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("insert chain: ");
        string input = Console.ReadLine();

        Console.WriteLine("choose character to count: ");
        char character = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == character)
            {
                count++;
            }
        }

        Console.WriteLine($"the character {character} appears {count} times!");
    }
}