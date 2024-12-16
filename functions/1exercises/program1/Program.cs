using System;

class Program
{
    static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
    {
        fahrenheit = (celsius * 9 / 5) + 32;
    }

    static void CelsiusToKelvin(double celsius, out double kelvin)
    {
        kelvin = celsius + 273.15;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit;
        double kelvin;

        CelsiusToFahrenheit(celsius, out fahrenheit);
        CelsiusToKelvin(celsius, out kelvin);

        Console.WriteLine($"{celsius}°C son {fahrenheit}°F.");
        Console.WriteLine($"{celsius}°C son {kelvin}K.");
    }
}