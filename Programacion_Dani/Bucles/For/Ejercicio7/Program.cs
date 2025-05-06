//(7) Dado un número por teclado, mostrar su tabla de multiplicar.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Introduce un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i <= 10; i++){
            int resultado = num * i;
            Console.WriteLine($"{num,4}x{i,2}={resultado,4}");
        }
    }
}
