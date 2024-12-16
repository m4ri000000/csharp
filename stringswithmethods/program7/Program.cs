using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("How many products are you buying?");
        int numProducts = Convert.ToInt32(Console.ReadLine());

        List<Tuple<string, double>> products = new List<Tuple<string, double>>();

        for (int i = 0; i < numProducts; i++)
        {
            Console.WriteLine($"Enter the name of product #{i + 1}: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter the price of {name}: ");
            double price = double.Parse(Console.ReadLine());

            products.Add(new Tuple<string, double>(name, price));
        }

        for (int i = 0; i < products.Count - 1; i++)
        {
            for (int j = i + 1; j < products.Count; j++)
            {
                if (products[i].Item2 > products[j].Item2)
                {
                    var temp = products[i];
                    products[i] = products[j];
                    products[j] = temp;
                }
            }
        }

        double total = 0;
        List<Tuple<string, double, double>> finalProducts = new List<Tuple<string, double, double>>();

        for (int i = 0; i < products.Count; i++)
        {
            if ((i + 1) % 3 == 0)
            {
                finalProducts.Add(new Tuple<string, double, double>(products[i].Item1, products[i].Item2, 0));
            }
            else
            {
                finalProducts.Add(new Tuple<string, double, double>(products[i].Item1, products[i].Item2, products[i].Item2));
                total += products[i].Item2;
            }
        }

        for (int i = 0; i < finalProducts.Count; i++)
        {
            Console.WriteLine($"{finalProducts[i].Item1} - original price: {finalProducts[i].Item2}€ - applied price: {finalProducts[i].Item3}€");
        }

        Console.WriteLine($"Amount to pay: {total}€");
    }
}