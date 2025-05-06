using System;
public class Program
{
    public static void Main()
    {
        
        private static void EscribirTextoEnFichero(string nf){
        FileStream fs;
        StreamWriter sw;
        int codChar;
        try
        {
            using (fs = new FileStream(nf, FileMode.Create))
            using (sw = new StreamWriter(fs))
            {
                Console.Write("Texto: ");
                while ((codChar = Console.Read()) != '.' && codChar != -1)
                    sw.Write(char.ToUpper((char)codChar));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("PROBLEMAS: " + e.Message);
        }
    }
    private static void EscribirEnFichero()
    {
        char letra;
        using (StreamWriter? doc = new StreamWriter(new FileStream("TextoLeido.txt", FileMode.Create)))
        {
            Console.WriteLine("Escribe");
            letra = (char)Console.Read();
            while (letra != '.' && )
            {
                letra = Char.ToUpper(letra);
                doc.Write(letra);
                letra = (char)Console.Read();
            }
        }
    }
}
}