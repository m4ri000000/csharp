﻿using System;


class Program
{
    static void Main()
    {
        decimal euroToBRL = 6.17m;

        Console.WriteLine("Enter the amount of euros: ");
        decimal euros = Convert.ToDecimal(Console.ReadLine());

        decimal brl = euros * euroToBRL;

        Console.WriteLine($"{euros} is approximately {brl} BRL.");
    }
}