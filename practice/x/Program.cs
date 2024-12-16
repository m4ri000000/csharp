using System;
class Program
{
    static void Main()
    {
        int numero = 3;

        do 
        {
            Console.Write("introduce un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"has introducido el numero {numero}");
        } while (numero > 0);

        Console.WriteLine("has introducido 0 o un numero negativo! saliendo...")
    }
}