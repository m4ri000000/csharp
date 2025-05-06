/*implementar programa normaliza
numero de segundos
en horas, minutos y segundos */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("esto es un convertidor de segundos!");
        Console.Write("introduce una cantidad de segundos: ");
        int total = Convert.ToInt32(Console.ReadLine());

        int horas = total / 3600;
        int minutos = (total % 3600) / 60;
        int segundos = total % 60;

        int[] tiempo = new int[3] {horas, minutos, segundos};

        Console.WriteLine($"{tiempo[0]} horas, {tiempo[1]} minutos, {tiempo[2]} segundos");
    }
}