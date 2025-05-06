using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string path = "test.txt";

        if (File.Exists(path))
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                int byteRead;
                while ((byteRead = fs.ReadByte()) != -1)
                {
                    Console.Write((char)byteRead);
                }
            }
        }
    }
}