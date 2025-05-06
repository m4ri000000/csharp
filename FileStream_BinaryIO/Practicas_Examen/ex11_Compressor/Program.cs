//file compressor
using System;
using System.IO;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string inputFile = "sample.txt";
        string outputFile = "compressed.txt";

        using (StreamReader sr = new StreamReader(inputFile))
        using (StreamWriter sw = new StreamWriter(outputFile))
        {
            string content = sr.ReadToEnd();
            string compressedContent = content.Replace(" ", "").Replace("\t", "").Replace("\n", "").Replace("\r", "");
            sw.Write(compressedContent);
        }

        Console.WriteLine("File compressed successfully...");
    }
}