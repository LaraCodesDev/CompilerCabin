static class AgeChecker
{
    public static void Run()
    {
        int alter = 0;
        Console.WriteLine("Alter");
        alter = int.Parse(Console.ReadLine() ?? "");

        if (alter < 18)
        {
            Console.WriteLine("Du bist minderjährig.");
        }

        else if (alter >= 18 && alter < 67)
        {
            Console.WriteLine("Du bist volljährig.");  
        }

        else
        {
            Console.WriteLine("Du bist im Rentenalter.");
        }
    }
}