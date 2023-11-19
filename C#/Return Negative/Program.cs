using System;

namespace Return_Negative
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.MakeNegative(1));
        }
    }
}

public static class Kata
{
    public static int MakeNegative(int number) => number > 0 ? number * -1 : number;
}