using System;
using System.Collections.Generic;
public class ItemManager
{
    private List<string> items;
    private Random random;
    public ItemManager()
    {
        items = new List<string>();
        random = new Random();
    }
    public void AddItem(string item)
    {
        items.Add(item);
    }
    public void RemoveItem(string item)
    {
        items.Remove(item);
    }
    public string ChooseItem()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Error, the list is empty.");
        }
        int index = random.Next(items.Count);
        return items[index];
    }
    public void DisplayList()
    {
        Console.WriteLine("Current list: ");
        foreach (var item in items)
        {
            Console.WriteLine("- " + item);
        }
    }
}