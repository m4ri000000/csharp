/*(10) Introduciremos números enteros por teclado  hasta pulsar el cero. 
Los número deben ser mayores de cero y menores de diez. 
Ordenar y presentar por pantalla estos números ordenados de mayor a menor y de menor a mayor.*/

using System;
class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        bool continuarIngresando = true;

        Console.WriteLine("Ingrese números aquí (mayores que 0 y menores que 10). ¡Ingrese 0 para terminar!");

        while (continuarIngresando)
        {
            Console.Write("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                continuarIngresando = false;
            }
            else if (num > 0 && num < 10)
            {
                numeros.Add(num);
            }
        }

        numeros.Sort();

        Console.WriteLine("\nNúmeros de menor a mayor:");
        for (int i = 0; i < numeros.Count; i++)
        {
            Console.Write(numeros[i] + " ");
        }

        numeros.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine("\nNúmeros de mayor a menor:");
        for (int i = 0; i < numeros.Count; i++)
        {
            Console.Write(numeros[i] + " ");
        }

    }
}
