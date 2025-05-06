// Dada una cadena de caracteres que contenga el nombre de una persona en formato
//  APELLIDOS, NOMBRE, convertirla en una cadena del tipo NOMBRE APELLIDOS.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string cadena;
        Console.Write("Coloca tu nombre en formato APELLIDOS, NOMBRE: ");
        cadena = Console.ReadLine();
        string[] nombre = cadena.Split(", ");
        Console.WriteLine(nombre[1] + " " + nombre[0]);
    }
}