using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter 10 numbers between 1 and 20 separated by spaces: ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = Convert.ToInt32(numbers[i]);
            if (number >= 1 && number <= 20)
            {
                Console.WriteLine($"{number}\t{new string('*', number)}");
            }
            else
            {
                Console.WriteLine("invalid number.");
            }
        }
    }
}