using System;

class Program
{
    static void Main(string[] args)
    {
        string input = ""; 
        
        while (input.ToLower() != "exit") 
        {
            Console.Write("Enter an integer (or type 'exit' to quit): ");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                continue; 
            }

            try
            {
                int n = Convert.ToInt32(input);
                if (n == 0)
                {
                    Console.WriteLine("The number is 0.");
                }
                else if (n % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid input. Please enter a valid integer.");
            }
        }
    }
}