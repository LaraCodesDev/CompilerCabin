static class GreetingMethod
{
    public static void Run()
    {
        SayHello("Lara");
        ShowAge(32);
        Showperson("Lara", 32);
        Showgame("Cyberpunk", 9);
    }

    static void SayHello(string name)
    {
        Console.WriteLine("Hallo!" + name);
    }

    static void ShowAge(int age)
    {
        Console.WriteLine("Du bist " + age + " Jahre alt");
    }

    static void Showperson(string name, int age)
    {
        Console.WriteLine(name + " ist " + age + " Jahre alt.");
    }
    
    static void Showgame(string name, int zahl)
    {
        Console.WriteLine(name + "Hat eine Bewertung von " + zahl +"/10");
    }
}