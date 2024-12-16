using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("insert chain: ");
        string input = Console.ReadLine();

        string result = "";

        bool foundNonSpace = false;

        for (int i = 0; i < input.Length; i++)
        {
            if (!foundNonSpace && input[i] != ' ')
            {
                foundNonSpace = true;
            }

            if (foundNonSpace)
            {
                result += input[i];
            }
        }
        Console.WriteLine("chain without spaces to the left: '" + result + "'");
    }
}