using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("insert chain of characters here: ");
        string input = Console.ReadLine();

        int lowercaseCount = 0;
        int uppercaseCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (char.IsLower(c))
            {
                lowercaseCount++;
            }
            else if (char.IsUpper(c))
            {
                uppercaseCount++;
            }
        }

        Console.WriteLine($"the amount of lowercase letters is: {lowercaseCount}.");
        Console.WriteLine($"the amount of uppercase letters is: {uppercaseCount}.");

    }
}