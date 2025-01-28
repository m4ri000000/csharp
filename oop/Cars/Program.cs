using System;
class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", "Corolla", 2020);
        Car car2 = new Car("Ford", "Mustang", 2020);
        Car car3 = new Car("Rolls-Royce", "Phantom", 2025);
        Car car4 = new Car("Aston Martin", "Vanquish", 2025);
        Car car5 = new Car("Ferrari", "12Cilindri", 2025);

        car1.DisplayInfo();
        car2.DisplayInfo();
        car3.DisplayInfo();
        car4.DisplayInfo();
        car5.DisplayInfo();
    }
}