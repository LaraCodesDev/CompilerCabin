static class TypeConversion
{
    public static void Run()
    {
        // ReadLine() liefert immer einen string.
        string input = Console.ReadLine()??"";

        // int.Parse() wandelt einen Text in eine ganze Zahl um.
        // Beispiel: "25" wird zu 25.
        int number = int.Parse(input);

        // Jetzt kann number wie eine normale int-Variable verwendet werden.
        Console.WriteLine("Deine Zahl: " + number);
    }
}