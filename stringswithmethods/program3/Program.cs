using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("insert name with the following format: LAST NAME, NAME: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(',');

        string lastName = parts[0].Trim();
        string name = parts[1].Trim();

        string result = name + " " + lastName;
        Console.WriteLine("the name in the format NAME LAST NAME is: " + result);
    }
}