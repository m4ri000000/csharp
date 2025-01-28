using System;
class List
{
    private int[] data;
    private int count;
    public List (int size)
    {
        data = new int[size];
        count = 0;
    }

    //method to add
    public void Add(int n)
    {
        if (count >= data.Length)
        {
            Resize();
        }

        data[count] = n;
        count++;
        Console.WriteLine($"Added: {n}");
    }

    //method to delete
    public void Delete(int n)
    {
        int index = Array.IndexOf(data, n, 0, count);
        if (index == -1)
        {
            Console.WriteLine($"{n} was not found");
            return;
        }

        //fill gap
        for (int i = index; i < count - 1; i++)
        {
            data[i] = data[i + 1];
        }
        Console.WriteLine($"Deleted: {n}");
    }

    //method to check if the array contains n
    public bool Contains(int n)
    {
        for (int i = 0; i < count; i++)
        {
            if (data[i] == n)
            {
                return true;
            }
        }
        return false;
    }

    private void Resize()
    {
        int newSize = data.Length * 2;
        int[] newArr = new int [newSize];
        for (int i = 0; i < data.Length; i++)
        {
            newArr[i] = data[i];
        }
        data = newArr;
        Console.WriteLine($"array resized to: {newSize}");
    }

    public void Display()
    {
        Console.WriteLine("Array: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }
}