using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "binary_file.bin";

        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(12345);
                bw.Write(67809);
                bw.Write(19211001);
            }
        }

        Console.WriteLine("binary data written to file...");
    }
}