namespace Century_From_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.СenturyFromYear(2000));
            Console.WriteLine(Kata.СenturyFromYear(1705));
        }
    }
}

public static class Kata
{
    public static int СenturyFromYear(int year) => year % 100 == 0 ? year / 100 : year / 100 + 1;
}