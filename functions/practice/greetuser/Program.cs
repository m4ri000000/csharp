//greet user
using System;

class Program
{
    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello {name}!");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        GreetUser(name);
    }
}