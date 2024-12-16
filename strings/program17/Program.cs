using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a number: ");
        string input = Console.ReadLine();

        bool isPalindromic = true;
        int length = input.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (input[i] != input[length - i - 1])
            {
                isPalindromic = false;
            }
        }
        if (isPalindromic)
        {
            Console.WriteLine("the number is palindromic.");
        }
        else
        {
            Console.WriteLine("the number is not palindromic.");
        }
    }
}