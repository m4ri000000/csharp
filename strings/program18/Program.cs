using System;

class Program
{
    static void Main()
    {
        Console.Write("enter chain: ");
        string input = Console.ReadLine();

        int uppercase = 0;
        int lowercase = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLower(input[i]))
            {
                lowercase++;
            }
            else if (char.IsUpper(input[i]))
            {
                uppercase++;
            }
        }

        Console.WriteLine($"the amount of lower case letters is {lowercase}.");
        Console.WriteLine($"the amount of upper case letters is {uppercase}.");
    }

}