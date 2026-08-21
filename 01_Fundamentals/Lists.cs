static class Lists
{
    public static void Run()
    {
        List<string> games = new List<string>();


        // Add fügt etwas hinzu.

        games.Add("Bendy");
        games.Add("Horizon");
        games.Add("Resident Evil");


        // Remove entfernt einen Wert.

        games.Remove("Horizon");


        // Count zeigt die Anzahl der Elemente.

        Console.WriteLine(games.Count);


        // Contains prüft,
        // ob ein bestimmter Wert enthalten ist.

        if (games.Contains("Bendy"))
        {
            Console.WriteLine("Bendy is in the list.");
        }


        // foreach geht alle Elemente durch.

        foreach (string game in games)
        {
            Console.WriteLine(game);
        }
    }
}