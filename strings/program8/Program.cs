using System;

class Program
{
    static void Main(string[] args)
    {
        string password = "eureka";
        int attempts = 3;

        while(attempts > 0)
        {
            Console.WriteLine("enter password: ");
            string input = Console.ReadLine();

            if (input == password)
            {
                return;
            }
            else
            {
                attempts--;
            }
        }
        Console.WriteLine("no attempts left.");
    }
}