using System;

namespace Returning_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Greet("Hilton"));
        }
    }
}

public static class Kata
{
    public static string Greet(string name) => $"Hello, {name} how are you doing today?";
}