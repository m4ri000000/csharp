// (3) Presenta por pantalla los números pares del 1 al 100.
using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        Console.WriteLine(contador);
        while(contador < 100)
        {
            contador += 2;
            Console.WriteLine(contador);
        }
    }
}