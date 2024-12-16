using System;

class Program
{
    static void Main()
    {
        string input;
        int i = 0;

        Console.WriteLine("write input here: ");
        input = Console.ReadLine().ToLower();

        Console.Write("The vowels found in the sentence: ");
        for(i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || input[i] == 'e' || input[i] == 'o' || input[i] == 'u')
            {
                Console.Write(input[i] + " ");
            }
        }
        Console.WriteLine();
    }
}