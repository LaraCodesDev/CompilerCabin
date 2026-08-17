static class WeekdayChecker
{
    public static void Run()
    {
        string[] wochentage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
        Console.WriteLine(wochentage[0]);
        Console.WriteLine(wochentage[6]);
        Console.WriteLine(wochentage.Length);

        foreach (var tag in wochentage)
        {
            Console.WriteLine(tag);
        }
        
    }
}