using System;

public class Program{
    public static void Main(string[] Args){
        ConjuntoDeEnteros c = new ConjuntoDeEnteros();

        c.Add(12);
        c.Add(13);
        c.Add(312);
        c.Delete(12); 
        c.Add(12);
        c.Add(532);

        Console.WriteLine(c);

        c.Delete(12); 

        Console.WriteLine(c);
    }
}