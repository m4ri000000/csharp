// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Acumulador a = new Acumulador();

        a.Add(5);
        a.Rem(3);
        a.Rem(3);   

        Console.WriteLine("Valor "+ a.Val());
    }
}
