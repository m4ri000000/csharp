using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("insert chain: ");
        string input = Console.ReadLine();

        string result = "";

        bool foundNonSpace = false;

        int i = 0;
        while (i < input.Length && input[i] == ' ')
        {
            i++;
        }

        int j = input.Length - 1;
        while (j >= 0 && input[j] == ' ')
        {
            j--;
        }

        for(int k = i; k <= j; k++)
        { 
            result += input[k];
        }

        Console.WriteLine("chain without spaces on both sides: '" + result + "'");

    }
}