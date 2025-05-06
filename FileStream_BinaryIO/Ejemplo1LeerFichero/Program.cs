using System;
using System.IO;
public class Program {
    public static void Main() {
        
        string path = "text.txt";

        StreamReader sw = new StreamReader(new FileStream(path, FileMode.Open));
        Console.WriteLine(sw.ReadLine());
        sw.Close();



        //StringReader texto = new StringReader("hola\nme llamo\ncesar");
        //Console.WriteLine((char)texto.Read());




        /*StringWriter prueba = new StringWriter();
        prueba.WriteLine("hola");
        prueba.WriteLine("me llamo cesar\ntengo 23 años");
        Console.WriteLine(prueba);*/




        /*StreamReader fichero;
        string linea;
        fichero = File.OpenText("prueba1LeerFichero.txt");
        Console.WriteLine(fichero.ReadLine());
        fichero.Close();*/
    }
}