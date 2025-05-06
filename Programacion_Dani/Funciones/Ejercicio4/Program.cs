// (4) Muestra por pantalla los números del 1 al 100 -utilizando recursividad-.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Contador();
    }

    private static void Contador(){
        for(int i = 0; i <= 100; i++){
            Console.WriteLine(i);
        }
    }

}