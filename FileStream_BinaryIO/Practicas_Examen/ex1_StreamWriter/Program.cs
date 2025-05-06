using System;
using System.IO;
class Program
{
    static void Main()
    {
        string path = "sample.txt";
        
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("Hey this is the first line,");
            sw.WriteLine("while this is the second one");
            sw.WriteLine("and this is the last one!");
        }

        Console.WriteLine("text written...");
    }
}