using System;
public abstract class Character
{
    #pragma warning disable CS8618
    public string Name {get; set;}
    public int Health {get; set;}
    public int Mana {get;  set;}
    public int AttackPower {get; set;}
    public int Defense {get; set;}
    public Character (string name, int health, int mana, int attackpower, int defense)
    {
        Name = name;
        Health = health;
        Mana = mana;
        AttackPower = attackpower;
        Defense = defense;
    }

    public void Attack(Character target)
    {
        int dmg = Math.Max(0, AttackPower - target.Defense);
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacks {target.Name} for {dmg} damage.");
        if (target.Health <= 0)
        {
            target.Health = 0;
            Console.WriteLine($"{target.Name} has been defeated!");
        }
    }
    public void Defend()
    {
        Defense += 5;
        Console.WriteLine($"{Name}'s defense been raised by 5.");
    }
    public abstract void SpecialAbility(Character target);
    public override string ToString()
    {
        return $"{Name}: Health = {Health}, AttackPower = {AttackPower}, Defense = {Defense}";
    }
}

public class Warrior : Character
{
    public Warrior(string name) : base(name, 150, 15, 30, 10) {}
    public override void SpecialAbility(Character target)
    {
        Console.WriteLine($"{Name} uses Power Strike!");
        target.Health -= 50;
        if (target.Health <= 0)
        {
            target.Health = 0;
            Console.WriteLine($"{target.Name} has been defeated by the Power Strike!");
        }
    }
}
public class Mage : Character
{
    public Mage(string name) : base(name, 100, 50, 40, 5) { }

    public override void SpecialAbility(Character target)
    {
        Console.WriteLine($"{Name} casts Fireball!");
        target.Health -= 60;
        if (target.Health <= 0)
        {
            target.Health = 0;
            Console.WriteLine($"{target.Name} is scorched by the Fireball!");
        }
    }
}

public class Rogue : Character
{
    public Rogue(string name) : base(name, 120, 35, 40, 8) { }

    public override void SpecialAbility(Character target)
    {
        Console.WriteLine($"{Name} performs a Sneak Attack!");
        int criticalDamage = AttackPower * 2;
        target.Health -= criticalDamage;
        if (target.Health <= 0)
        {
            target.Health = 0;
            Console.WriteLine($"{target.Name} falls to the Sneak Attack!");
        }
    }
}