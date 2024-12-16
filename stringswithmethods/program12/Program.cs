using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];
        int[] result = new int[20];
        
        Console.WriteLine("Enter 20 positive integers:");

        for (int i = 0; i < 20; i++)
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.Write($"Enter number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out numbers[i]) && numbers[i] > 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }
        }

        Console.WriteLine("Enter the number to search for:");
        int searchNumber = 0;  
        bool validSearchInput = false;
        while (!validSearchInput)
        {
            if (int.TryParse(Console.ReadLine(), out searchNumber) && searchNumber > 0)
            {
                validSearchInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        for (int i = 0; i < 20; i++)
        {
            result[i] = (numbers[i] == searchNumber) ? -1 : 0;
        }

        Console.WriteLine("\nInitial vector:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();  

        Console.WriteLine("\nResult vector:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();  
    }
}