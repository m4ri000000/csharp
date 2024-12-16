using System;

class Program
{
    static void Main(string[] args)
    {
        string input1, input2;
        int i = 0;

        Console.WriteLine("write first input here: ");
        input1 = Console.ReadLine();

        Console.WriteLine("write second input here: ");
        input2 = Console.ReadLine();

        bool found = false;

        do
        {
            bool match = true;

            for (int j = 0; j < input2.Length && match; j++)
            {
                if (input1[i + j] != input2[j])
                {
                    match = false;
                }
            }

            if (match)
            {
                found = true;
            }

            i++;
        } while (!found && i <= input1.Length - input2.Length);

        if (found)
        {
            Console.WriteLine("Está!/Found!");
        }
    }
}