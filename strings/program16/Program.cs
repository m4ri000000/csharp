using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("insert chain: ");
        string input = Console.ReadLine();

        string baseInput = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                baseInput += input[i];
            }
        }

        bool isPalindrome = true;
        int length = baseInput.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (baseInput[i] != baseInput[length - 1 - i])
            {
                isPalindrome = false;
            }
        }
        if (isPalindrome)
        {
            Console.WriteLine($"the string {input} is a palindrome.");
        }
        else
        {
            Console.WriteLine("the string is not a palindrome.");
        }

    }
}