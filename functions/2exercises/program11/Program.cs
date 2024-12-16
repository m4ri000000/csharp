/*Crear una función a la que se le pasa un número que representa el año, 
y devuelve true si se trata de una año bisiesto y false si no lo es.*/

using System;
class Program
{
    static bool esBisiesto(int anio)
    {
        if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int anio = 2020;
        bool resultado = esBisiesto(anio);
        Console.WriteLine($"el año {anio} es bisiesto: {resultado}");
    }
}