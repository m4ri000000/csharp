using System;

class Program
{
    static void Main(string[] args)
    {
        string path = "sample.txt";
        using (StreamWriter sw = new StreamWriter(path, true))
        {
            sw.WriteLine("this is an append line");
            sw.WriteLine("appending allows adding content without overwriting!");
        }

        Console.WriteLine("text appended to file successfully...");
    }
}