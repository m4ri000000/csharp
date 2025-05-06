//file splitter
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string inputFile = "largefile.txt";
        int linesPerFile = 85;

        using (StreamReader sr = new StreamReader(inputFile))
        {
            int fileCounter = 1;
            int lineCounter = 0;
            StreamWriter sw = new StreamWriter($"output_part{fileCounter}.txt");

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (lineCounter == linesPerFile)
                {
                    sw.Close();
                    fileCounter++;
                    sw = new StreamWriter($"output_part{fileCounter}.txt");
                    lineCounter = 0;
                }

                sw.WriteLine(line);
                lineCounter++;
            }

            sw.Close();
        }

        Console.WriteLine("File split successfully.");
    }
}