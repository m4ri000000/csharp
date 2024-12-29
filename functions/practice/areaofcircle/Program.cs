using System;
class Program
{
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    static void Main()
    {
        Console.WriteLine("enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = CalculateCircleArea(radius);
        Console.WriteLine($"the area is {area}.");
    }
}