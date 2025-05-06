using System;

class Program
{
    static void Main(string[] args)
    {
        string path = "sample.txt";
        if (File.Exists(path))
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}