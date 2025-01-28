using System;
class Car
{
    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }

    public Car (string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car details: {Make} {Model} {Year}");
    }
}