// (1) Presenta por pantalla los números del 1 al 100.
using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 100;
        Console.WriteLine(contador);
        while(contador > 0)
        {
            contador--;
            Console.WriteLine(contador);
        }
    }
}