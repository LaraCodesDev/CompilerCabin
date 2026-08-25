public static class CharacterManager
{
    public static void Run()
    {
        Console.WriteLine("Wie ist dein Spielername?");
        string playerName = Console.ReadLine()??"";

        Begrüßung(playerName);

        Console.WriteLine("Wie ist dein Level?");
        int level = int.Parse(Console.ReadLine()??"");

        Console.WriteLine($"Dein Spieler {playerName} ist Level {level}");

        if (level >= 20)
        {
            Console.WriteLine("Erfahrener Spieler!");
        }
        else if (level >= 10)
        {
            Console.WriteLine("Fortgeschrittener Spieler");
        }
        else
        {
            Console.WriteLine("Anfänger!");
        }

        for (int i = 1; i <= level; i++)
        {
            Console.WriteLine($" Level-Schritt {i}");
        }

        List <string> skills = new List <string>();

        skills.Add("C#");
        skills.Add("Git");
        skills.Add("Debugging");

        foreach (var skill in skills)
        {
            Console.WriteLine(skill);
        }

        Character player = new Character();
        player.Name = playerName;
        player.Level = level; 
        player.Skills = skills;
        Console.WriteLine(player.Name);
        Console.WriteLine(player.Level);

        foreach (var skill in skills)
        {
            Console.WriteLine(skill);
        }
    }
        public static void Begrüßung(string playerName)
        {
            Console.WriteLine($"Willkommen {playerName}");
        }
    
        
}