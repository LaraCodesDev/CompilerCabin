static class Conditions
{
    public static void Run()
    {
        int age = 20;

        // if prüft eine Bedingung.
        // Ist die Bedingung true, wird der Code im Block ausgeführt.
        if (age >= 18)
        {
            Console.WriteLine("Adult");
        }

        // else wird ausgeführt, wenn die if-Bedingung false ist.
        else
        {
            Console.WriteLine("Minor");
        }


        int temperature = 15;

        // else if wird benutzt, wenn mehrere Fälle geprüft werden sollen.
        if (temperature >= 25)
        {
            Console.WriteLine("Warm");
        }
        else if (temperature >= 10)
        {
            Console.WriteLine("Mild");
        }
        else
        {
            Console.WriteLine("Cold");
        }


        bool hasTicket = true;
        int userAge = 22;

        // && bedeutet UND.
        // Beide Bedingungen müssen true sein.
        if (userAge >= 18 && hasTicket)
        {
            Console.WriteLine("Access granted");
        }


        // || bedeutet ODER.
        // Mindestens eine Bedingung muss true sein.
        bool isAdmin = false;
        bool isModerator = true;

        if (isAdmin || isModerator)
        {
            Console.WriteLine("Permission granted");
        }


        // ! bedeutet NICHT.
        bool isLocked = false;

        if (!isLocked)
        {
            Console.WriteLine("Door is open");
        }
    }
}