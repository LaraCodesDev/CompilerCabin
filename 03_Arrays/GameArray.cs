static class GameArray
{
    public static void Run()
    {
        string[] games = { "Horizon", "Cyberpunk", "Minecraft", "The Witcher" };
        Console.WriteLine(games[3]);
        Console.WriteLine(games[0]);
        Console.WriteLine(games[2]);
        Console.WriteLine(games.Length);

        foreach (var game in games)
        {
            Console.WriteLine(game);
        }
        
    }
}