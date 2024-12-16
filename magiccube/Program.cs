using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("\nWelcome to the magic Square program!");
        Console.Write("insert the size of the magic square, remember! it must only be an odd number: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[,] magicSquare = new int[size, size];

        MagicSquare(magicSquare, size);
        Console.WriteLine("here, it is the magical square box!");
        Display(magicSquare, size);  
    }

    static void MagicSquare(int[,] magicSquare, int size)
    {
        int row = size / 2; 
        int col = 2;
        int num = 1;

        while (num <= size * size)
        {
            magicSquare[row, col] = num;
            num++;

            int nextRow = (row + 1) % size;
            int nextCol = (col + 1) % size;

            if (magicSquare[nextRow, nextCol] != 0)
            {
                col = (col - 1 + size) % size;
            }
            else
            {
                row = nextRow;
                col = nextCol;
            }
        }
    }

    static void Display(int[,] magicSquare, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(magicSquare[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}