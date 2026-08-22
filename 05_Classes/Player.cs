class Player
{

    private string name;
    public string Name
    {
        get
        {
            return name;
        } 
        set
        {
            name = value;
        }
    }
    private int lvl;
    public int Lvl
    {
        get
        {
            return lvl;
        }
        set
        {
            lvl = value;
        }

    }

    public Player(string Name, int Lvl)
    {
        name = Name;
        lvl = Lvl;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Player: " + Name + " | " + " Level: " + Lvl);
    }

    public bool IsHighLevel()
    {
        if (lvl >= 50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ShowLevelStatus()
    {
        if (IsHighLevel())
        {
            Console.WriteLine("High Lvl");
        }
    
        else
        {
        Console.WriteLine("Low Lvl");
        }
    }
}
