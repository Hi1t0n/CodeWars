using System;
using System.Linq;

namespace How_good_are_you_really
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.BetterThanAverage(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75));
        }
    }
}


public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        return YourPoints > ClassPoints.Average();
    }
}