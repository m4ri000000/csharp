using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("the answer is: " + Chooser());
    }
    static string Chooser()
    {
        string[] c = ["yes", "no"];
        Random random = new Random();
        return c[random.Next(c.Length)];
    }
}