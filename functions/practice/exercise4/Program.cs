using System;
class Program
{
    static long[] ContarDigitos(long numero)
    {
        long[] contador = new long[10];
        long digito = 0;

        while (numero > 0)
        {
            digito = numero % 10;
            contador[digito]++;
            numero /= 10;
        }

        return contador;
    } 

    static void MostrarFrecuencia(long[] frecuencias)
    {
        for (int i = 0; i < frecuencias.Length; i++)
        {
            if(frecuencias[i] > 0)
            {
                Console.WriteLine($"{i} aparece {frecuencias[i]} vez/veces.");
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("ingresa el numero: ");
        long numero = Convert.ToInt64(Console.ReadLine());

        long[]frecuencias = ContarDigitos(numero);
        MostrarFrecuencia(frecuencias);
    }
}