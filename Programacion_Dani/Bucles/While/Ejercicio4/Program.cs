// (4) Dado un número introducido por teclado que debe ser menor que 100, presentar todos los números impares que van desde él hasta el 100.
using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Ingresa un número (menor a 100): ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num >= 100)
        {
            Console.WriteLine("El número ingresado es mayor o igual a 100, por favor ingresa un número menor a 100:");
            num = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Números impares desde " + num + " hasta 100:");
        while (num <= 100)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }
            num++;
        }
    }
}
