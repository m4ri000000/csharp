using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "binary_file.bin";
        if (File.Exists(path))
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    Console.WriteLine(br.ReadInt32());
                    Console.WriteLine(br.ReadInt32());
                    Console.WriteLine(br.ReadInt32());
                }
            }
        }
    }
}