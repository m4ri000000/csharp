using DanielDarias;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // DNI d = new DNI(78695986, 'F');
        // DNI d2 = new DNI(78695986, 'Z');
        // DNI d3 = new DNI(79092361, 'F');

        // Console.WriteLine(d.Equals(d3));

        // Persona p = new Persona(32, 79092361, 'F');

        // Console.WriteLine(p.DNI);

        Estudiante j = new Estudiante("Juan JR.", 12, 1234567, 'L');
        j.Calificar("PRO", 5f);

        Estudiante d = new Estudiante("Juan", 13, 1234567, 'L');

        Console.WriteLine(d.Equals(j));

        Console.WriteLine(j);


    }
}