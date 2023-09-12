namespace cprofHomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISettings settings = new GameSettings();
            RandomNumberGenerator generator = new RandomNumberGenerator();
            Game game = new Game(settings, generator);

            game.Start();
        }
    }
}