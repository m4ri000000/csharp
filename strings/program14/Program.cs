using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("insert chain: ");
        string input = Console.ReadLine();

        string result = "";

        bool foundNonSpace = false;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (!foundNonSpace && input[i] != ' ')
            {
                foundNonSpace = true;
            }

            if (foundNonSpace)
            {
                result = input[i] + result;
            }
        }
        Console.WriteLine("chain without spaces to the right: '" + result + "'");
    }
}