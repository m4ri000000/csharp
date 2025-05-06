//file merger
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string[]inputFiles = {"file1.txt", "file2.txt", "file3.txt"};
        string outputFile = "merged.txt";

        try
        {
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                foreach (var file in inputFiles)
                {
                    if (File.Exists(file))
                    {
                        using (StreamReader sr = new StreamReader(file))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("file doesn't exist!");
                    }
                }
            }

            Console.WriteLine("Files merged successfully...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}