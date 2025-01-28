using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> games = new List<string>
        {
            "God of War",
            "The Last of Us",
            "Hades",
            "God of War Ragnarok",
            "Resident Evil 2",
            "Elden Ring",
            "Sekiro"
        };

        Random random = new Random();

        int randInd = random.Next(games.Count);

        Console.WriteLine("The game to play is: " + games[randInd]);
    }
}