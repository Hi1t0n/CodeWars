using System;
using System.Linq;

namespace Count_of_positives_sum_of_negatives
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var result = Kata.CountPositivesSumNegatives(null);
            foreach (var res in result)
            {
                Console.Write(res + " ");
            }
            result = Kata.CountPositivesSumNegatives(new int[] {0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14});
            foreach (var res in result)
            {
                Console.Write(res + " ");
            }
        }
    }
}

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input is null || input.Length is 0)
        {
            return new int[] { };
        }

        return new int[] { input.Count(x => x > 0), input.Where(x => x < 0).Sum() };
    }
}