using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter sentence here: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        int i = 0;

        for (i = 0; i < words.Length; i++)
        {
            Console.WriteLine($"{words[i]} {words[i].Length}");
        }
    }
}