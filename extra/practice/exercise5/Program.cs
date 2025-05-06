using System;
class Program
{
    static int[] ConvertirDistancia(int distanciaMetros)
    {
        int kilometros = distanciaMetros / 1000;
        int metros = distanciaMetros % 1000;
        int centimetros = distanciaMetros * 100;

        return new int[3] { kilometros, metros, centimetros};
    }

    static void Main()
    {
        Console.Write("escribe una distancia en metros: ");
        int distanciaMetros = Convert.ToInt32(Console.ReadLine());

        int[] distancia = ConvertirDistancia(distanciaMetros);

        Console.WriteLine($"{distancia[0]} kilometros, {distancia[1]} metros, {distancia[2]} centimetros.");
    }
}