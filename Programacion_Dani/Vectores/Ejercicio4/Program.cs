/* (4) Solicitar una cantidad no definida de datos y calcular su suma. Debe estar preparado para un máximo de 100 números, que pedirá de uno en uno. 
Cuando se introduzca un valor cero, mostrará la suma de todos los anteriores y dará el número de datos introducidos.*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int maxValores = 10;
        int[] lista = new int[maxValores];
        int incremento = 0, suma = 0;
        int numero = -1;

        while (incremento < maxValores && numero != 0)
        {
            Console.Write("Dame un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            lista[incremento] = numero;
            suma += numero;
            incremento++;
        }

        Console.WriteLine("La suma de todos los números es: " + suma);
    }
}
