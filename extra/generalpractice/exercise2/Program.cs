using System;
class Program
{
    static void Main()
    {
        int total = 0;
        bool valido = false;

        while (!valido)
        {
            Console.Write("ingresa un numero de segundos: ");
            try
            {
                total = Convert.ToInt32(Console.ReadLine());
                if (total < 0)
                {
                    Console.WriteLine("ingresa un valor valido");
                }
                else
                {
                    valido = true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("entrada invalida.");
            }
        }

        int horas = total / 3600;
        int minutos = (total % 3600) / 60;
        int segundos = total % 60;

        int[] tiempo = new int[3] { horas, minutos, segundos};

        Console.WriteLine($"{tiempo[0]} horas, {tiempo[1]} minutos, {tiempo[2]} segundos");
    }
}