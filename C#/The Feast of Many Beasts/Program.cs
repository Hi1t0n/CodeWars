using System;

namespace The_Feast_of_Many_Beasts
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.Feast("great blue heron", "garlic naan"));
        }
    }
}

public class Kata
{
    public static bool Feast(string beast, string dish) =>
        beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
}