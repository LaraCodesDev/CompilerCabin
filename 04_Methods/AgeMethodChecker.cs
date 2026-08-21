static class AgeMethodChecker
{
    public static void Run()
    {
       string result = CheckAge(22);
       Console.WriteLine(result); 
    }

    static string CheckAge(int age)
    {
        if (age >=18)
        {
            return "Adult";
        }

        else
        {
            return "Minor";
        }
    }
}