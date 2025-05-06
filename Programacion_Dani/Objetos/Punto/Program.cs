using System;

public class Program
{
    static void Main(string[] args)
    {
        Punto p = new Punto(-11, 8);
        Punto q = new Punto();
        q.x = 14;
        q.y = 11;
        p.Mostrar('.');
        Console.WriteLine($"\np = {p}");
        Console.WriteLine($"q = {q}");
        Console.WriteLine($"dist(p,q) = {p.distancia(q)}");
    }
}