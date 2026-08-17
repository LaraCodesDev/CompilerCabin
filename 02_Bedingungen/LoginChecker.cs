static class LoginChecker
{
    public static void Run()
    {
        string name = "Lara";
        string passwort = "Cabin123";

        Console.WriteLine("Benutzername");
        name = Console.ReadLine() ?? "";

        Console.WriteLine("Passwort");
        passwort = Console.ReadLine() ?? "";

        if (name == "Lara" && passwort == "Cabin123")
        {
            Console.WriteLine("Zugriff erlaubt");
        }
        else
        {
            Console.WriteLine("Zugriff verweigert");
        }
    }
}