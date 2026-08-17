static class RabattChecker
{
    public static void Run()
    {
        int alter = 0;
        alter = int.Parse(Console.ReadLine() ?? "");

        string rabatt = "Ja";
        rabatt = Console.ReadLine() ?? "";

        if (alter < 18 || rabatt == "ja")
        {
            Console.WriteLine("Rabatt erhalten!");
        }
        else
        {
            Console.WriteLine("Kein Rabatt!");
        }
    }
}