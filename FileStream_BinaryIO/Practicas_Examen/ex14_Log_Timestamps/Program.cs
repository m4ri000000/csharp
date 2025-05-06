//create log with timestamps
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string logFile = "log.txt";
        using (StreamWriter writer = new StreamWriter(logFile, true))
        {
            writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Program started.");
            string path = "samplefile.txt";
            File.Create(path).Close();
            writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - File {path} created successfully.");
            using (StreamWriter fileWriter = new StreamWriter(path))
            {
                fileWriter.WriteLine("This is a sample text.");
            }
            writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Written to {path}.");
        }

        Console.WriteLine("Actions logged successfully.");

    }
}