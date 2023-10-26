using System;
using System.Linq;

namespace Get_the_mean_of_an_array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetAverage(new int[]{2,2,2,2}));
            Console.WriteLine(Kata.GetAverage(new int[]{5,10}));
        }
    }
}

public class Kata
{
    public static int GetAverage(int[] marks) => (int)Math.Floor(marks.Sum() / (double)marks.Length);
}