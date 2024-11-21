namespace FrostFire.Engine;

public static class RandomNumberGenerator
{
    private static Random _random = new Random();

    private static int GetRandomNumberBetween(int min, int max)
    {
        return _random.Next(min, max);
    }
}
