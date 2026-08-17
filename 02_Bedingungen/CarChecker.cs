static class CarChecker
{
    public static void Run()
    {
        int alter = 0;
        Console.WriteLine("Alter");
        alter = int.Parse(Console.ReadLine() ?? "");

        string Führerschein = "Ja";
        Führerschein = Console.ReadLine() ?? "";

        string Begleitperson = "Ja";
        Begleitperson = Console.ReadLine() ?? "";

        if (alter >= 18 && (Führerschein == "ja" || Begleitperson == "ja"))
        {
        Console.WriteLine("Fahrt erlaubt!");
        }

        else
        {
            Console.WriteLine("Fahrt nicht erlaubt!");  
        }

    }
}