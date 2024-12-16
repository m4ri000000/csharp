using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("choose character: ");
        char character = Console.ReadKey().KeyChar;

        Console.WriteLine("\nIntroduce amount of repetitions:");
        string input = Console.ReadLine();
        int n = Convert.ToInt32(input);
        string result = "";

        for (int i = 0; i < n; i++)
        {
            result += character;
        }

        Console.WriteLine("the result is: " + result);
    }
}