static class ScoreAnalyzer
{
    public static void Run()
    {
        int[] scores = { 45, 82, 67, 91, 38, 76, 55 };

        int bestanden = 0;
        int durchgefallen = 0;

        foreach (var score in scores)
        {
            if (score >= 60)
            {
                bestanden++;
            }   
            else
            {
                durchgefallen++;
            }
        }
        Console.WriteLine("Bestanden "+ bestanden);
        Console.WriteLine("Durchgefallen "+ durchgefallen);
    }
}