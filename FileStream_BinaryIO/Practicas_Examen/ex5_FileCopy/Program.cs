using System;
using System.IO;
class Program
{
    static void Main()
    {
        string sourcePath = "sample.txt";
        string newPath = "copy_sample.txt";

        if (File.Exists(sourcePath))
        {
            File.Copy(sourcePath, newPath, overwrite: true);
            Console.WriteLine("file copied...");
        }
    }
}