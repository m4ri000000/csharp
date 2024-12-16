using System;
class Program
{
    static void Main(string[] args)
    {
        //ask for phrase and word to remove

        Console.WriteLine("insert sentence: ");
        string input = Console.ReadLine();

        Console.WriteLine("insert word: ");
        string word = Console.ReadLine();

        int count = 0;
        int i = 0;
        string result = "";

        while (i < input.Length)
        {
            string currentWord = "";

            while (i < input.Length && input[i] != ' ')
            {
                currentWord += input[i];
                i++;
            }

            if(currentWord == word)
            {
                count++;
            }
            else
            {
                if(result.Length > 0)
                {
                    result += " ";
                }
                result += currentWord;
            }

            i++;
        }

        Console.WriteLine("result sentence: " + result);
        Console.WriteLine("amount of times the word was erased: " + count);
        
    }
}