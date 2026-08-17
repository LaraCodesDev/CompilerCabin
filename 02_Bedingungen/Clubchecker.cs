static class ClubChecker
{
    public static void Run()
    {
        string Ticket = "Ticket";
        int Alter = 0;

        Console.WriteLine("Alter");
        Alter = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Ticket");
        Ticket = Console.ReadLine() ?? "";

        if (Alter >= 18 && Ticket == "ja")
        {
            Console.WriteLine("Einlass erlaubt!");
        }
        else
        {
            Console.WriteLine("Einlass verweigert!");
        }
    }
}