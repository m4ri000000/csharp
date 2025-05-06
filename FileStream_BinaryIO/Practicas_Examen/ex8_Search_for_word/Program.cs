using System;
using System.IO;
class Program
{
    static void Main()
    {
        string path = "test.txt";
        string term = "line";

        if (File.Exists(path))
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(term))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}