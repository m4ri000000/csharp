using System;
    public abstract class Shape
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base("Rectangle")
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double sideA, double sideB, double sideC) : base("Triangle")
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }