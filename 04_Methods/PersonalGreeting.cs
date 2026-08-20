static class PersonalGreeting
{
    static void Run()
    {
        GreetPerson("Lara");
        ShowPersonInfo("Lara", 32);
        int result = AddNumbers(5, 10);
        Console.WriteLine(result);
        int multiplyResult = MultiplyNumbers(4, 6);
        Console.WriteLine(multiplyResult);
        string name = CreateGreeting("Lara");
        Console.WriteLine(name);
        int Difference = CalculateDifference(50, 18);
        Console.WriteLine(Difference);
    }
    
    static void GreetPerson(string name)
    {
        Console.WriteLine("Hallo " + name);
    }

    static void ShowPersonInfo(string name, int age)
    {
        Console.WriteLine(name + " ist "+ age + " alt");
    }

    static int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }

    static int MultiplyNumbers(int number1, int number2)
    {
        return number1 * number2;
    }

    static string CreateGreeting(string name)
    {
        return "Hallo " + name;
    }

    static int CalculateDifference(int number1, int number2)
    {
        return number1 - number2;
    }
}