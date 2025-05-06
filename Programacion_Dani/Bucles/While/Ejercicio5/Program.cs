// (5) Incluir en algoritmo anterior las suma de cuántos números impares se muestran.
using System;

class Program
{
    static void Main(string[] args)
    {
        int num; 
        int suma = 0;
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
                suma += num;
                Console.WriteLine(num);
            }
            num++;
        }
        Console.WriteLine("La suma de los números impares es: " + suma);
    }
}
