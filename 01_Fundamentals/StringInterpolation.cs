public static class StringInterpolation
{
    public static void Run()
    {
        // String Interpolation
        // Mit einem $ vor dem String können Variablen
        // direkt in einen Text eingesetzt werden.

        string playerName = "Cabin";
        int level = 100;

        // Die Variable kommt zwischen { }.
        Console.WriteLine($"Name: {playerName}");
        Console.WriteLine($"Level: {level}");

        // Mehrere Variablen können im selben String verwendet werden.
        Console.WriteLine($"Spieler {playerName} ist Level {level}.");


        // Ohne String Interpolation:
        Console.WriteLine("Spieler " + playerName + " ist Level " + level + ".");

        // Mit String Interpolation:
        Console.WriteLine($"Spieler {playerName} ist Level {level}.");


        // MERKE:
        // $"..."     -> aktiviert String Interpolation
        // {variable} -> setzt den Wert der Variable in den Text ein
        //
        // Beispiel:
        // string name = "Lara";
        // Console.WriteLine($"Hallo {name}");
        //
        // Ausgabe:
        // Hallo Lara
    }
}