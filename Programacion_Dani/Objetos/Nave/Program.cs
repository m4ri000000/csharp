using System;

public class Program
{
    public static void Main(string[] args)
    {
        Nave a = new Nave();

        a.MejorarEscudo();
        a.MejorarEscudo();
        a.MejorarEscudo();
        a.MejorarEscudo();
        a.MejorarEscudo();
        a.MejorarEscudo();
        a.MejorarEscudo();
        a.MejorarEscudo();
        a.MejorarEscudo();
        a.MejorarEscudo();
        a.MejorarEscudo();
        a.AumentarVida(100);
        a.MejorarNave();


        Console.WriteLine(a.ToString());

        Console.WriteLine("--------------------");

        a.AumentarVida(100);

        Console.WriteLine(a.ToString());
    }
}