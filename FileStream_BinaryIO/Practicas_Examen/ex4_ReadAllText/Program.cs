using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string path = "sample.txt";

        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
    }
}