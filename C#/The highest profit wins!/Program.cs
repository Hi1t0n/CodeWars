using System;
using System.Linq;
namespace The_highest_profit_wins_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = MinMax.minMax(new int[] { 1, 2, 5, -1, 12, 20 });
            foreach (int i in arr) { Console.WriteLine(i); }
        }
    }
}

public class MinMax
{
    public static int[] minMax(int[] lst)
    {
        return lst.Length is not 0 ? new int[] { lst.Min(), lst.Max()} : lst; 
    }
}