namespace Opposite_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Opposite(1));
            Console.WriteLine(Kata.Opposite(2311));
            Console.WriteLine(Kata.Opposite(-1));
        }
    }
}

public class Kata
{
    public static int Opposite(int number) => number * -1;
}