using System;

class Program
{
    static void TemperatureConverter(double celsius, string temp, out double resultado)
    {
        if (temp.ToUpper() == "F")
        {
            resultado = (celsius * 9 / 5) + 32;
        }
        else if (temp.ToUpper() == "K")
        {
            resultado = celsius + 273.15;
        }
        else
        {
            resultado = 0;
            Console.WriteLine("Input inválido. Use 'F' para Fahrenheit o 'K' para Kelvin.");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        Console.Write("¿A qué escala quiere convertirla? Usa 'F' para Fahrenheit, y 'K' para Kelvin: ");
        string temp = Console.ReadLine().ToUpper();

        double resultado;

        TemperatureConverter(celsius, temp, out resultado);

        if (temp == "F" || temp == "K")
        {
            Console.WriteLine($"{celsius}°C son {resultado}°{temp}.");
        }
    }
}