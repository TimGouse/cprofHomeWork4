
namespace cprofHomeWork4
{
    public class Game
    {
        private readonly ISettings _settings;
        private readonly RandomNumberGenerator _generator;

        public Game(ISettings settings, RandomNumberGenerator generator)
        {
            _settings = settings;
            _generator = generator;
        }

        public void Start()
        {
            int targetNumber = _generator.Generate(_settings.Min, _settings.Max);
            int attempts = 0;

            Console.WriteLine($"Угадайте число между {_settings.Min} и {_settings.Max}. У вас есть {_settings.Attempts} попыток.");

            while (attempts < _settings.Attempts)
            {
                Console.Write("Введите ваше число: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == targetNumber)
                {
                    Console.WriteLine("Поздравляем! Вы угадали число!");
                    return;
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }

                attempts++;
                Console.WriteLine($"Осталось попыток: {_settings.Attempts - attempts}");
            }

            Console.WriteLine($"Игра окончена. Загаданное число было: {targetNumber}");
        }
    }
}
