// (1) Dada una temperatura en grados Celcius, realizar una función que convierta esa cantidad a grados Fahrenheit y otra a grados Kelvin.

using System;

public class Program{
    public static void Main(string[] args){
        double celcius;

        Console.Write("Introduce tu temperatura en Celcius: ");
        celcius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"En Kevil es {Kelvin(celcius)} y en Fahrenheit {Fahrenheit(celcius)}");
    }

    private static double Kelvin(double input){

        double kelvin = input + 273.15;

        return kelvin;
    }

    private static double Fahrenheit(double input){
        double fahrenheit = input + 32;

        return fahrenheit;
    }
    
}