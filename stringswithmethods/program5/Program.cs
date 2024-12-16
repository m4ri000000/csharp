using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter sentence here: ");
        string input = Console.ReadLine();

        string inputNoSpaces = input.Trim(' ');

        Console.WriteLine($"the sentence without spaces is '{inputNoSpaces}'.");
    }
}
