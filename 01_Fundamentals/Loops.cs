static class Loops
{
    public static void Run()
    {
        // for wird benutzt, wenn man ungefähr weiß,
        // wie oft etwas wiederholt werden soll.

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }


        // i++ erhöht eine Zahl um 1.
        int number = 5;
        number++;

        Console.WriteLine(number);


        // i-- verringert eine Zahl um 1.
        number--;

        Console.WriteLine(number);


        // while läuft so lange,
        // wie die Bedingung true ist.

        int counter = 0;

        while (counter < 3)
        {
            Console.WriteLine(counter);
            counter++;
        }


        // foreach geht jedes Element einer Sammlung durch.

        string[] games =
        {
            "Bendy",
            "Horizon",
            "Resident Evil"
        };

        foreach (string game in games)
        {
            Console.WriteLine(game);
        }


        // break beendet eine Schleife sofort.

        foreach (string game in games)
        {
            if (game == "Horizon")
            {
                break;
            }

            Console.WriteLine(game);
        }
    }
}