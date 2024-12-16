using System;

class Program
{
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    static int MaxOfTwo(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void GreetUser(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("enter two numbers to add: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = AddNumbers(num1, num2);
        Console.WriteLine("The sum is: " + sum);

        Console.WriteLine("\nEnter length and width to calculate the area of a rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());
        double width = Convert.ToDouble(Console.ReadLine());
        double area = CalculateArea(length, width);
        Console.WriteLine("The area of the rectangle is: " + area);

        Console.WriteLine("\nEnter two numbers to find the maximum:");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());
        int max = MaxOfTwo(num3, num4);
        Console.WriteLine("The maximum value is: " + max);

        Console.WriteLine("\nEnter your name to receive a greeting:");
        string name = Console.ReadLine();
        GreetUser(name);
    }
}