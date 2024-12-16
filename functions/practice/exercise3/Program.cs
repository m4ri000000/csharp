using System;
class Program
{
    static double[] CalcularPremios(double premioTotal, double[] porcentajes)
    {
        double sumaPorcentajes = 0;
        foreach (double porcentaje in porcentajes)
        {
            sumaPorcentajes += porcentaje;
        }

        double[] premios = new double[porcentajes.Length];

        for (int i = 0; i < porcentajes.Length; i++)
        {
            premios[i] = (premioTotal * porcentajes[i]) / 100;
        }

        return premios;
    }
    static void Main()
    {
        Console.WriteLine("inserir premio total: ");
        double premioTotal = Convert.ToDouble(Console.ReadLine());
        Console.Write("inserir el numero de personas: ");
        int numPersonas = Convert.ToInt32(Console.ReadLine());

        double[] porcentajes = new double [numPersonas];

        Console.WriteLine("ingresa los porcentajes para cada persona: ");
        for (int i = 0; i < numPersonas; i++)
        {
            Console.Write($"persona {i + 1}: ");
            porcentajes[i] = Convert.ToDouble(Console.ReadLine());
        }

        double[] premios = CalcularPremios(premioTotal, porcentajes);

        Console.WriteLine("distribucion: ");
        for (int i = 0; i < premios.Length; i++)
        {
            Console.WriteLine($"Persona {i + 1}: {premios[i]:0.00} euros");
        }
    }
}