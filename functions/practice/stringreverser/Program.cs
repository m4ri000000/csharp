using System;

class Program
{
    
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("enter a string: ");
        string input = Console.ReadLine();
        string reversed = ReverseString(input);
        Console.WriteLine($"reversed string: {reversed}");
    }
}