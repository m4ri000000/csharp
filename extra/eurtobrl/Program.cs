using System;

class CurrencyConverter
{
    static void Main(string[] args)
    {
        const double exchangeRate = 6.34;

        Console.WriteLine("Welcome to the Euro to Brazilian Real Converter!");
        Console.Write("Enter the amount in Euros (EUR): ");
        
        if (double.TryParse(Console.ReadLine(), out double euros))
        {
            double reais = euros * exchangeRate;
            Console.WriteLine($"{euros} EUR is approximately {reais:F2} BRL.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}