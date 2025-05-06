using System;
using System.IO;
using System.Drawing;
class Program
{
    static void Main()
    {
        string filePath = "archivo.bin";
        // Escribir un byte usando BinaryWriter
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
                byte dato1 = 4;
                byte dato2 = 5;
                writer.Write(dato1);
                writer.Write(dato2);
                Console.WriteLine($"Bytes escritos: 0x{dato1}, 0x{dato2}");
        }

        // Leer el byte usando BinaryReader
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            byte[] bytesLeidos = reader.ReadBytes(2); // Leer 2 bytes
            Console.WriteLine($"Bytes leídos: 0x{bytesLeidos[0]}, 0x{bytesLeidos[1]}");
        }

        // Para leer con un bucle seria hasta qu detectara el -1
        int b;
        while ((b = fs.ReadByte()) != -1)
        {
            Console.WriteLine($"Byte leído: {b}");
        }

        // Para leer todos los bytes de una imagen 
        string rutaOriginal = "foto.jpg";
        string copiaRuta = "copia.jpg";

        byte[] datosImagen = File.ReadAllBytes(rutaOriginal);

        Console.WriteLine($"La imagen tiene {datosImagen.Length} bytes.");

        File.WriteAllBytes(copiaRuta, datosImagen);

        Console.WriteLine("Copia de la imagen guardada.");

        // Leer todas las lineas de un archivo
        string contenido = File.ReadAllText("archivo.txt");
        Console.WriteLine(contenido);
    }
}