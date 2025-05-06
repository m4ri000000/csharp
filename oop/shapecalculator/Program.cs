using System;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager manager = new ShapeManager();

            while (true)
            {
                Console.WriteLine("Choose a shape to add:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string choice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the radius of the circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        manager.AddShape(new Circle(radius));
                        break;

                    case "2":
                        Console.Write("Enter the width of the rectangle: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the height of the rectangle: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        manager.AddShape(new Rectangle(width, height));
                        break;

                    case "3":
                        Console.Write("Enter the first side of the triangle: ");
                        double sideA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second side of the triangle: ");
                        double sideB = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the third side of the triangle: ");
                        double sideC = Convert.ToDouble(Console.ReadLine());
                        manager.AddShape(new Triangle(sideA, sideB, sideC));
                        break;

                    case "4":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nAdded shape successfully!\n");
                manager.DisplayAllShapesInfo();
            }
        }
    }
}