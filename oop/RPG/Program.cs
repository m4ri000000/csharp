using System;
public class Program
{
    public static void Main()
    {
        Warrior warrior = new Warrior("SoloHer");
        Mage mage = new Mage("Agatha");
        Rogue rogue = new Rogue("Ezio");

        Console.WriteLine(warrior);
        Console.WriteLine(mage);
        Console.WriteLine(rogue);

        Console.WriteLine("\nBattle Begins!");
        warrior.Attack(mage);
        mage.SpecialAbility(warrior);
        rogue.SpecialAbility(mage);

        Console.WriteLine("\nFinal Stats:");
        Console.WriteLine(warrior);
        Console.WriteLine(mage);
        Console.WriteLine(rogue);
    }
}