using System;

namespace Thinkful___Logic_Drills_Traffic_light
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.UpdateLight("green"));
            Console.WriteLine(Kata.UpdateLight("yellow"));
            Console.WriteLine(Kata.UpdateLight("red"));
        }
    }
}

public class Kata
{
    public static string UpdateLight(string current)
    {
        switch (current)
        {
            case "green":
                return "yellow";
            case "yellow":
                return "red";
            case "red":
                return "green";
            default:
                return null;
        }
    }
}