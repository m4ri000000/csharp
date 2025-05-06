//word searcher
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "largefile.txt";
        string searchTerm = "nisi";
        using (StreamReader sr = new StreamReader(inputFile))
        {
            string line;
            int lineNumber = 0;
            bool found = false;

            while ((line = sr.ReadLine()) != null)
            {
                lineNumber++;
                if (line.Contains(searchTerm))
                {
                    Console.WriteLine($"Line {lineNumber}: {line}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"The word '{searchTerm}' was not found in the file.");
            }
        }

    }
}