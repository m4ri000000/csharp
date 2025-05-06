using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {   
        List<int> numbers = new List<int>();
        bool continueEntering = true;

        Console.WriteLine("enter numbers here (bigger than 0 and smaller than 10). enter 0 to end!");
        
        while (continueEntering)
        {
            Console.Write("enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                continueEntering = false;
            }
            else if (num > 0 && num < 10)
            {
                numbers.Add(num);
            }
        }

        numbers.Sort();

        Console.WriteLine("\nNumbers from smaller to bigger:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        numbers.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine("\nNumbers from bigger to smaller:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }

    }
}