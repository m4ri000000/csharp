//file comparison tool
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string file1 = "file1.txt";
        string file2 = "file2.txt";

        try
        {
            if (File.Exists(file1) && File.Exists(file2))
            {
                string[] file1Lines = File.ReadAllLines(file1);
                string[] file2Lines = File.ReadAllLines(file2);

                bool filesAreIdentical = true;
                int maxLines = Math.Max(file1Lines.Length, file2Lines.Length);

                for (int i = 0; i < maxLines; i++)
                {
                    if (i >= file1Lines.Length)
                    {
                        Console.WriteLine($"File 2 has extra line: {file2Lines[i]}");
                        filesAreIdentical = false;
                    }
                    else if (i >= file2Lines.Length)
                    {
                        Console.WriteLine($"File 1 has extra line: {file1Lines[i]}");
                        filesAreIdentical = false;
                    }
                    else if (file1Lines[i] != file2Lines[i])
                    {
                        Console.WriteLine($"Difference at line {i + 1}:");
                        Console.WriteLine($"File 1: {file1Lines[i]}");
                        Console.WriteLine($"File 2: {file2Lines[i]}");
                        filesAreIdentical = false;
                    }
                }

                if (filesAreIdentical)
                {
                    Console.WriteLine("The files are identical.");
                }
            }
            else
            {
                Console.WriteLine("One or both files do not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}