static class GameDemo
{
    public static void Run()
    {
        Game bendy = new Game("Bendy", 30, 16);
        bendy.ShowInfo();
        bendy.IsAllowed();

        Game outlast = new Game("Outlast", 25, 18);
        outlast.ShowInfo();
        outlast.IsAllowed();

        Game minecraft = new Game("Minecraft", -10, 7);
        minecraft.ShowInfo();
        minecraft.IsAllowed();
    }
}