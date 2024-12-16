/* programa que devuelva un cambio, calculandolo con el
numero menor posible de monedas y billetes
hay una cantidad ilimitada de monedas (2, 1)
y billetes (500, 200, 100, 50, 20, 10, 5)*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("precio: ");
        int precio = Convert.ToInt32(Console.ReadLine());

        Console.Write("pagado: ");
        int pagado = Convert.ToInt32(Console.ReadLine());

        int cambio = pagado - precio;

        if (cambio < 0)
        {
            Console.WriteLine("fondos insuficientes!");
            return;
        }

        Console.WriteLine($"su cambio es: {string.Join(" ", CalcularCambio(cambio))}");
    }
    static int[] CalcularCambio(int cambio)
    {
        int[] monedas_billetes = {500, 200, 100, 50, 20, 10, 5, 2, 1};
        int[] resultado = new int[monedas_billetes.Length];

        for (int i = 0; i < monedas_billetes.Length; i++)
        {
            while (cambio >= monedas_billetes[i])
            {
                cambio -= monedas_billetes[i];
                resultado[i]++;
            }
        }

        int total = 0;
        for (int i = 0; i < resultado.Length; i++)
        {
            total += resultado[i];
        }

        int[] cambioFinal = new int[total];
        int index = 0;

        for (int i = 0; i < resultado.Length; i++)
        {
            for (int j = 0; j < resultado[i]; j++)
            {
                cambioFinal[index++] = monedas_billetes[i];
            }
        }

        return cambioFinal;
    }
}