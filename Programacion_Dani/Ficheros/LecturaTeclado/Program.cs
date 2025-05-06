using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string nf = "texto.txt";
        int caracter;

        try
        {
            // Abrir el archivo una sola vez al inicio
            using (FileStream fs = new FileStream(nf, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                Console.WriteLine("Introduce caracteres (termina con '.'):");


                while ((caracter = Console.Read()) != '.')
                {
                    sw.Write(char.ToUpper((char)caracter));
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("\n\n---> " + e.Message);
        }
    }
}