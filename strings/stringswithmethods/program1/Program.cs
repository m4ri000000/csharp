using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter chain: ");
        string input = Console.ReadLine().ToLower();
        string vowels = "aeiou";
        string vowelsFound = "";
        int i = 0; //programacion segun fernando
        char c;

        for (i = 0; i < input.Length; i++)
        {
            c = input[i];
            if (vowels.IndexOf(c) != -1 && !vowelsFound.Contains(c))
            {
                vowelsFound += c + " ";
            }
        }

        if (vowelsFound != "")
        {
            Console.WriteLine($"the vowels found are {vowelsFound.Trim()}.");
        }
    }
}