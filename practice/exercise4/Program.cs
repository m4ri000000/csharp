using System;
class Program
{
    static int[] ConvertirSegundos(int total)
    {
        int horas = total / 3600;
        int minutos = (total % 3600) / 60;
        int segundos = total % 60;

        return new int[3] { horas, minutos, segundos};
    }

    static void Main()
    {
        Console.WriteLine("Bienvenido al convertidor de segundos!");
        Console.Write("Ingresa una cantidad de segundos: ");
        int total = Convert.ToInt32(Console.ReadLine());

        int[] tiempo = ConvertirSegundos(total);

        Console.WriteLine($"{tiempo[0]} horas, {tiempo[1]} minutos, {tiempo[2]} segundos");
    }
}