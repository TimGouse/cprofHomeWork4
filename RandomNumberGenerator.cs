
namespace cprofHomeWork4
{
    public class RandomNumberGenerator
    {
        public int Generate(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
