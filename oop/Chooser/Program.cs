using System;
class Program
{
    static void Main(string[] args)
    {
        ItemManager manager = new ItemManager();
        string input;
        Console.WriteLine("Add items to the list, enter 'done' when finished.");
        while (true)
        {
            Console.Write("enter item: ");
            #pragma warning disable CS8600 
            input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            manager.AddItem(input);
        }

        Console.WriteLine();
        manager.DisplayList();

        //chooser
        Console.WriteLine();
        Console.WriteLine("Randomly selected item: " + manager.ChooseItem());
    }
}