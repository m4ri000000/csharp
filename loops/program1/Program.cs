//Comprobar que un número introducido por teclado es primo y que que es mayor que 1

using System;
class Program
{
    static void Main()
    {
       Console.WriteLine("introduce un numero: ");
       int num = Convert.ToInt32(Console.ReadLine());

       if (num > 1)
       {
            bool esPrimo = true;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                }
            }

            if (esPrimo)
            {
                Console.WriteLine("es un numero primo.");
            }
            else
            {
                Console.WriteLine("el numero no es primo.");
            }
       }
       else
       {
            Console.WriteLine("el numero tiene que ser mayor de 1.");
       }
    }
}