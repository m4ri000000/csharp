// (1) Dada una cadena de caracteres introducida por teclado, contar el número de caracteres que la componen.
using System;

public class Program {
    public static void Main(string[] args){
        Console.WriteLine("Introduce una cadena de caracteres: ");
        string? texto = Console.ReadLine();
        Console.WriteLine($"Tiene un total de {texto?.Length} caracteres.");
    }
}