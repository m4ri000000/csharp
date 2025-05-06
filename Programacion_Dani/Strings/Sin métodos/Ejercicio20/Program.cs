// (20) Dado un código ISBN (identificador de libros) saber si este código es un ISBN válido (aplicar el de 13 dígitos). 

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string? isbn;
        Console.Write("Introduce tu ISBN: ");
        isbn = Console.ReadLine();

        if (isbn != null)
        {
            if (isbn.Length == 13)
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length - 1; i++)
                {
                    int digito = int.Parse(isbn[i].ToString());
                    if (i % 2 == 0)
                    {
                        suma += digito;
                    }
                    else
                    {
                        suma += digito * 3;
                    }
                }
                int digitoVerificador = int.Parse(isbn[isbn.Length - 1].ToString());
                int digitoControl = 10 - (suma % 10);
                if (digitoControl == digitoVerificador)
                {
                    Console.WriteLine("El ISBN es válido.");
                }
                else
                {
                    Console.WriteLine("El ISBN no es válido.");
                }
            }
            else
            {
                Console.WriteLine("El ISBN no es válido.");
            }
        }
    }
}