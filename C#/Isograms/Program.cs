using System;
using System.Linq;
namespace Isograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsIsogram("ban"));
            Console.WriteLine(Kata.IsIsogram("banan"));
        }
    }
}


public class Kata
{
    public static bool IsIsogram(string str)
    {
        str = str.ToLower();
        for (int i = 0; i < str.Length; i++)
        {
            int val = str.Count(x => x == str[i]);
            if(val > 1) { return false; }
        }
        return true;
    }
}