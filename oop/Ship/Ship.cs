using System;
using System.Drawing;
public class Ship
{
    public int Size {get; private set;} = 1;
    public int Life {get; private set;} = 100;
    public int LifeLimit {get; private set;} = 100;
    public int Shot {get; private set;} = 1;
    public int Shield {get; private set;} = 0;

    public void IncreaseLife (int amount)
    {
        if (amount != 10 && amount != 100)
        {
            Console.WriteLine("Life can only be increased by 10 or 100 units.");
            return;
        }

        Life = Math.Min(Life + amount, LifeLimit);
    }
    public void IncreaseShield ()
    {
        if (Shield < 10)
        {
            Shield++;
        }
        else
        {
            Console.WriteLine("Maximum shield level reached.");
        }
    }

    public void IncreaseShip ()
    {
        if (Size < 10)
        {
            Size++;
            LifeLimit = Size * 100;
            if (Life < LifeLimit)
            {
                Life = LifeLimit;
            }
        }
        else
        {
            Console.WriteLine("The ship is at its maximum size.");
        }
    }
    public void IncreaseShot()
    {
        if (Shot < 10)
        {
            Shot++;
        }
    }
    public void Attack(int dmg)
    {
        if (dmg != 10 && dmg != 100 && dmg != 1000)
        {
            Console.WriteLine("You can only attack in units of 10, 100 or 1000.");
            return;
        }

        if (Shield > 10)
        {
            int reducedShield = Math.Min(Shield, dmg / 10);
            Shield -= reducedShield;
            dmg -= reducedShield * 10;
        }

        if (dmg > 0)
        {
            Life -= dmg;
            if (Life <= 0)
            {
                Life = 0;
                Console.WriteLine("Ship has been wrecked.");
            }
        }
    }
    public override string ToString()
    {
        return $"Size: {Size}, Life: {Life}/{LifeLimit}, Shot: {Shot}, Shield: {Shield}";
    }
}

