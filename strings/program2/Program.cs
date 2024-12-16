using System;

class Program
{
    static void Main()
    {
        string input;
        string inputLetter;
        int counter = 0;
        int i;
        char letter = '\0';

        Console.WriteLine("insert chain: ");
        input = Console.ReadLine();

        Console.WriteLine("insert letter to find: ");
        inputLetter = Console.ReadLine();

        if(inputLetter.Length == 1)
        {
            letter = inputLetter[0];
        }

        for (i = 0; i < input.Length; i++)
        {
            if(input[i] == letter)
            {
                counter++;
            }
        }
        
        Console.WriteLine($"the letter {letter} appears {counter} times in the sentence {input}.");
    }
}