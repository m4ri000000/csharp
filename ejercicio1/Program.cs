using System;
using System.IO;

class Ejercicio1 {
    static void Main(){

        string ficheroEntrada = "entrada.txt";
        if(!File.Exists(ficheroEntrada)) {
            using (StreamWriter writer = new StreamWriter(ficheroEntrada)) {
                writer.WriteLine("33;15");
                writer.WriteLine("50;12");
                writer.WriteLine("88;1");
                writer.WriteLine("60;17");
            }
            Console.WriteLine("Fichero creado.");
        }

        string ficheroSalida = "salida.txt";
        
        using (StreamReader sr = new StreamReader(ficheroEntrada))
        using (StreamWriter sw = new StreamWriter(ficheroSalida)) {
            string linea;
            while ((linea = sr.ReadLine()) != null) {
                string[] partes = linea.Split(';');
                if (partes.Length == 2 &&
                    int.TryParse(partes[0], out int num1) &&
                    int.TryParse(partes[1], out int num2)) {
                    int suma = num1 + num2;
                    sw.WriteLine($"{num1} + {num2} = {suma}");
                }
            }
        }
    }
}