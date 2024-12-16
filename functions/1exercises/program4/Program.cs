using System;

class Program
{
    static void MostrarNumerosHasta100(int inicio, int fin)
    {
        for (int i = inicio; i <= fin; i++)
        {
            Console.Write(i + " ");
        }
    }

    static void Main(string[] args)
    {
        MostrarNumerosHasta100(1, 100);
    }
}