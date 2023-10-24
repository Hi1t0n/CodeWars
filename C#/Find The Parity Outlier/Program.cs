using System.Collections.Generic;
using System.Linq;
using System;

namespace Find_The_Parity_Outlier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Find(new int[] { 2, 6, 8, -10, 3 });
        }
    }
}



public class Kata
{
    public static int Find(int[] integers)
    {
        int[] res = integers.Where(x => x % 2 == 0).ToArray();
        return res.Length == 1 ? res[0] : Convert.ToInt32(integers.First(x => x % 2 != 0));
    }
}