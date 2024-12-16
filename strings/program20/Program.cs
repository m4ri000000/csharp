using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter 13 digit ISBN: ");
        string isbn = Console.ReadLine();

        int sum = 0;

        for (int i = 0; i < 12; i++)
        {
            int digit = isbn[i] - '0';

            if (i % 2 == 0)
            {
                sum += digit;
            }
            else
            {
                sum += digit * 3;
            }
        }

        int check = (10 - (sum %10)) % 10;

        if (check == (isbn[12] - '0'))
        {
            Console.WriteLine("the ISBN is valid.");
        }
        else
        {
            Console.WriteLine("the ISBN is not valid.");
        }
    }
}