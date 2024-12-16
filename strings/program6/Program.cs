using System;

class Program
{
    static void Main()
    {
        string input;
        int vowelCount = 0;

        Console.WriteLine("write input here: ");
        input = Console.ReadLine().ToLower();

        for(int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || input[i] == 'e' || input[i] == 'o' || input[i] == 'u')
            {
                vowelCount++;
            }
        }
        Console.WriteLine("the number of vowels in the sentence is: " + vowelCount);
    }
}