using System;
class Program
{
    static void Main()
    {
        Ship ship = new Ship();

        Console.WriteLine("Initial ship state:");
        Console.WriteLine(ship);

        Console.WriteLine("Increasing shield and shot...");
        ship.IncreaseShield();
        ship.IncreaseShot();
        Console.WriteLine(ship);

        Console.WriteLine("Attacking with 100 damage...");
        ship.Attack(100);
        Console.WriteLine(ship);

        Console.WriteLine("Increasing life by 100 units...");
        ship.IncreaseLife(100);
        Console.WriteLine(ship);

        Console.WriteLine("Upgrading the ship...");
        ship.IncreaseShip();
        Console.WriteLine(ship);

        Console.WriteLine("Attacking with 1000 damage...");
        ship.Attack(1000);
        Console.WriteLine(ship);
    }
}