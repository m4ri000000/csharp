using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter first chain: ");
        string input1 = Console.ReadLine();

        Console.WriteLine("enter second chain: ");
        string input2 = Console.ReadLine();

        if (input1.IndexOf(input2) != -1)
        {
             Console.WriteLine("Está.");
        }
    }
}