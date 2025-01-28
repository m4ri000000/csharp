using System;
class Program
{
    static void Main(string[] args)
    {
        List list = new List(2);

        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(50);

        list.Display();

        Console.WriteLine($"Contains 20: {list.Contains(20)}");
        Console.WriteLine($"Contains 40: {list.Contains(40)}");

        list.Delete(50);
        list.Display();

        list.Add(60);
        list.Add(50);
        list.Display();

        list.Add(101);
        list.Display();
    }
}