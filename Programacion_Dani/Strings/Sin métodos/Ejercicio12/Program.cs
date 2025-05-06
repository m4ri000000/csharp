// (12) Desarrolla un programa que devuelva una cadena con un carácter repetido n veces, siendo n solicitado por teclado.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        // Generar un carácter aleatorio
        char caracter = (char)random.Next('a', 'z' + 1); 
        int n;
        Console.WriteLine("Carácter generado aleatoriamente: " + caracter);
        Console.Write("Introduce el número de veces que quieres repetir el caracter: ");
        n = Convert.ToInt32(Console.ReadLine());

        string resultado = "";
        for (int i = 0; i < n; i++)
        {
            resultado += caracter;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}
