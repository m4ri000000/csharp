// (6) Pide números por teclado, hasta que sumen 50 o más.
using System;

public class Program
{

    public static void Main(string[] args)
    {
        int num;
        int suma = 0;
        Console.Write("Ingresa un número (menor a 50): ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num >= 50)
        {
            Console.Write("El número ingresado es mayor o igual a 50, por favor ingresa un número menor a 50:");
            num = Convert.ToInt32(Console.ReadLine());
        }

        while (suma < 50)
        {
            if ((num + suma) > 50)
            {
                Console.Write("La suma de los números ingresados es mayor a 50, por favor ingresa un número menor a " + (50 - suma) + ": ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                suma += num;
                Console.WriteLine("La suma de los números ingresados es: " + suma);
                if (suma == 50)
                {
                    Console.WriteLine("La suma de los números ingresados es igual a 50, no puedes ingresar más números.");
                }
                else
                {
                    Console.Write("Ingresa un número (menor a 50): ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}