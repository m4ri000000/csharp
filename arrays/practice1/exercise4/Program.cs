using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[100];
        int suma = 0;
        int contador = 0;
        int num = 0;

        Console.WriteLine("introduce numeros (pulsa 0 para salir): ");
        Console.Write($"numero {contador + 1}: "); 
        num = Convert.ToInt32(Console.ReadLine()); 
        while (contador < 100 && num != 0) 
        {
            numeros[contador] = num;
            suma += num; 
            contador++; 
            Console.Write($"numero {contador + 1}: "); 
            num = Convert.ToInt32(Console.ReadLine()); 
        }

        Console.WriteLine($"\nla suma de los numeros es {suma}");
        Console.WriteLine($"la cantidad de datos introducidos es {contador}");

    }
}