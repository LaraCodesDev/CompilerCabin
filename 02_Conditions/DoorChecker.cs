static class DoorChecker
{
    public static void Run()
    {
        Console.WriteLine("Alter");

        int Alter = 0;
        Alter = int.Parse(Console.ReadLine() ?? "");

        if (Alter >= 18)
        {
            Console.WriteLine("Tür öffnet sich");
        }
        else
        {
            Console.WriteLine("Du kommst hier nicht rein");
        }
    }
}