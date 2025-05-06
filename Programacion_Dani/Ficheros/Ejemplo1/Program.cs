using System;
using System.IO; // Para StreamWriter
public class CrearArchivoYEscribir
{
    public static void Main()
    {
        StreamWriter fichero = new StreamWriter("prueba.txt");
        fichero.WriteLine("Esto es una línea");
        fichero.Write("Esto es otra");
        fichero.WriteLine(" y esto es continuación de la anterior");
        fichero.Close();
    }
}
