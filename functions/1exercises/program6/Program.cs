using System;

class Program
{
    public static void Shoot(char[,] board, string shotCoord)
    {
        const char WATER = '·';
        const char SHOT = '*';
        const char SHIP = 'S';
        int row, col;
        ExtractCoordinates(shotCoord, out row, out col);

        if (row < 0 || row >= 10 || col < 0 || col >= 10)
        {
            Console.WriteLine("Invalid coordinates. Try again.");
            return;
        }

        if (board[row, col] == WATER || board[row, col] == SHOT)
        {
            Console.WriteLine(board[row, col] == WATER ? "You shot at water." : "You already shot here!");
        }
        else if (board[row, col] == SHIP)
        {
            board[row, col] = SHOT;
            Console.WriteLine("Hit!");
        }
    }

    static void ExtractCoordinates(string coordinate, out int row, out int col)
    {
        col = coordinate[0] - 'A';
        row = int.Parse(coordinate[1..]) - 1;
    }

    static void Main(string[] args)
    {
        char[,] board = new char[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                board[i, j] = '·';
            }
        }

        board[0, 0] = 'S';
        board[1, 1] = 'S';
        board[2, 1] = 'S';
        board[2, 2] = 'S';
        board[2, 3] = 'S';
        board[2, 4] = 'S';
        board[2, 5] = 'S';
        board[2, 6] = 'S';
        board[4, 4] = 'S';

        board[6, 3] = 'S';
        board[6, 4] = 'S';
        board[6, 5] = 'S';

        board[8, 0] = 'S';
        board[8, 1] = 'S';
        board[8, 2] = 'S';
        board[8, 3] = 'S';

        board[9, 8] = 'S';


        bool playing = true;

        while (playing)
        {
            Console.WriteLine("Enter the coordinate to shoot (e.g., A1, B2) or type 'exit' to quit:");
            string shotCoordinate = Console.ReadLine();

            if (shotCoordinate.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Game over. Exiting...");
                playing = false;
            }
            else
            {
                Shoot(board, shotCoordinate);
            }
        }

    }
}