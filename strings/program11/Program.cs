using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("insert sentence: ");
        string input = Console.ReadLine();

        int i = 0;

        while (i < input.Length)
        {
            string word = "";

            while (i < input.Length && input[i] != ' ')
            {
                word += input[i];
                i++;
            }

            Console.WriteLine($"{word} ({word.Length} characters.)");

            i++;
        }
    }
}