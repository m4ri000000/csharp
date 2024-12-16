/*Realizar una función a la que dado un número entero (este numero no podrá ser menor o igual que 0),  
determine el número de cifras que tiene. Por ejemplo, si introduzco un 253, me devuelva un 3.*/
using System;
class Program
{
    static int ContarCifras(int numero)
    {
        int cifras = 0;
        while (numero > 0)
        {
            numero = numero / 10;
            cifras++;
        }
        return cifras;
    }

    static void Main()
    {
        int numero = 23;
        int resultado = ContarCifras(numero);
        Console.WriteLine($"el numero {numero} tiene {resultado} cifras.");
    }
}