using System;
using System.Collections.Generic;
public class ShapeManager
{
    private List<Shape> shapes;

    public ShapeManager()
    {
        shapes = new List<Shape>();
    }

    public void AddShape(Shape shape)
    {
        shapes.Add(shape);
    }

    public void DisplayAllShapesInfo()
    {
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.Name}");
            Console.WriteLine($"Area: {shape.CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {shape.CalculatePerimeter():F2}");
            Console.WriteLine(new string('-', 20));
        }
    }
}