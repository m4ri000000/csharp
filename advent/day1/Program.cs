//tenemos dos listas de numeros
//hay que ver cual es la diferencia entre ellas
//juntamos los numeros mas pequeños
//calculamos la diferencia absoluta
//sumamos todas las diferencias para conseguir la distancia total
using System;
class Day1
{
    static void Main()
    {
        int[] primeraLista = { 3, 4, 2, 1, 3, 3 };
        int[] segundaLista = { 4, 3, 5, 3, 9, 3 };

        int distanciaTotal = CalcularDistancia(primeraLista, segundaLista);

        Console.WriteLine($"la distancia total entre las dos listas es: {distanciaTotal}");
    }

    static int CalcularDistancia(int[] primeraLista, int[] segundaLista) //int 
    {
        Array.Sort(primeraLista);
        Array.Sort(segundaLista);

        int distanciaTotal = 0;
        int i;

        for (i = 0; i < primeraLista.Length; i++)
        {
            distanciaTotal += Math.Abs(primeraLista[i] - segundaLista[i]);
        }

        return distanciaTotal;
    }
}