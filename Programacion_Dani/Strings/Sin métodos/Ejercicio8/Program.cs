/* (8) Teniendo en cuenta que la clave es “eureka”, escribir un algoritmo que nos pida una clave. 
Solo tenemos 3 intentos para acertar, si fallamos los 3 intentos nos mostrara un mensaje indicándonos que hemos agotado esos 3 intentos. Si acertamos la clave, saldremos directamente del programa.*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string? cadena;
        string clave = "eureka";

        Console.Write("Introduce tu clave: ");
        cadena = Console.ReadLine();

        int intentos = 0;
        while (cadena != clave && intentos < 2)
        {
            Console.Write("Introduce tu clave: ");
            cadena = Console.ReadLine();

            intentos++;

        }
        if (cadena == clave)
        {
            Console.Write("Felcidades!!");
        }
        else
        {
            Console.Write("Has pérdido tus 3 intentos.");
        }
    }
}