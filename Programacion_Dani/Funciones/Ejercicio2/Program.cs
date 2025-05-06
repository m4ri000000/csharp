// (2) Realizar el mismo ejercicio anterior, pero al pasar a la función los grados Celcius, también se le pasará una “F” para pasar a grados Fahrenheit, o una “K” para pasar a grados Kelvin.

using System;

public class Program{
    public static void Main(string[] args){
        double celcius;
        char seleccion;
        Console.Write("Introduce tu temperatura en Celcius: ");
        celcius = Convert.ToDouble(Console.ReadLine());

        Console.Write("¿A qué quieres pasarlo? (f/k)");
        seleccion = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        

        Console.WriteLine($"El resultado es {Transformacion(celcius, seleccion)}");
    }

    private static double Transformacion(double input, char valor){
        double solucion = 0;

        if(valor == 'k'){
            solucion = input + 273.15;
        }else if(valor == 'f'){
            solucion = (input * 9 / 5) + 32;
        }

        return solucion;
    }
    
}