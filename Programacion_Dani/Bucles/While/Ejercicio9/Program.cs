// (9) Solicitados cinco números por teclado, calcular cuál es el de mayor valor y cuál el de menor y mostrarlos por pantalla.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num, mayor, menor, i = 0;
        Console.Write("Ingrese 5 números:");
        num = Convert.ToInt32(Console.ReadLine());
        mayor = num;
        menor = num;

        while (i < 4)
        {
            i++;
            num = Convert.ToInt32(Console.ReadLine());


            if (num > mayor)
            {
                mayor = num;
            }
            else if (num < menor)
            {
                menor = num;
            }
        }

        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("El número menor es: " + menor);
    }
}
