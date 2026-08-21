static class Methods
{
    public static void Run()
    {
        // Methode ohne Parameter und ohne Rückgabewert.
        SayHello();


        // Methode mit einem Parameter.
        GreetPerson("Lara");


        // Methode mit mehreren Parametern.
        ShowPlayer("Lara", 32);


        // Methode mit Rückgabewert.
        int result = AddNumbers(10, 5);

        Console.WriteLine(result);


        // Methode mit if/else und Rückgabewert.
        string ageResult = CheckAge(22);

        Console.WriteLine(ageResult);
    }


    // void bedeutet:
    // Die Methode gibt keinen Wert zurück.

    static void SayHello()
    {
        Console.WriteLine("Hello");
    }


    // Parameter sind Werte,
    // die beim Methodenaufruf hineingegeben werden.

    static void GreetPerson(string name)
    {
        Console.WriteLine("Hello " + name);
    }


    // Eine Methode kann mehrere Parameter haben.

    static void ShowPlayer(string name, int age)
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
    }


    // int bedeutet hier:
    // Die Methode gibt eine ganze Zahl zurück.

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }


    // string bedeutet:
    // Die Methode gibt Text zurück.

    static string CheckAge(int age)
    {
        if (age >= 18)
        {
            return "Adult";
        }
        else
        {
            return "Minor";
        }
    }
}