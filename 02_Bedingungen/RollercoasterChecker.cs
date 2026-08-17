using System.Net.Mail;

static class RollerCoasterChecker
{
    public static void Run()
    {
        int größe = 0;
        Console.WriteLine("Größe");
        größe = int.Parse(Console.ReadLine() ?? "");

        int alter = 0;
        Console.WriteLine("Alter");
        alter = int.Parse(Console.ReadLine() ?? "");

        if (alter >= 12 && größe >= 140)
        {
          Console.WriteLine("Du darfst fahren!");    
        }

        else
        {
            Console.WriteLine("Du darfst nicht fahren!");
        }
    }
}