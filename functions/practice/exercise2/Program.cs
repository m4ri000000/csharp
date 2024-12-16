using System;
class Program
{
    static string CalculadorCajas(int articulos, int capacidad)
    {
        int cajasCompletas = articulos / capacidad;
        int sobrantes = articulos % capacidad;

        return $"{cajasCompletas} cajas y {sobrantes} articulos sobrantes.";
    }

    static void Main()
    {
        Console.Write("ingresa capacidad de cada caja: ");
        int capacidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("ingresa numero de articulos: ");
        int articulos = Convert.ToInt32(Console.ReadLine());

        string resultado = CalculadorCajas(articulos, capacidad);
        Console.WriteLine(resultado);
    }
}