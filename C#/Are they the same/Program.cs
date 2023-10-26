using System;
using System.Linq;

namespace Are_they_the_same
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = new int[] {11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19};
            Console.WriteLine(AreTheySame.comp(a, b));
        }
    }
}

class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (a is null || b is null || a.Length != b.Length){ return false; }
        int[] sortA = (int[])a.Clone();
        int[] sortB = (int[])b.Clone();
        Array.Sort(sortA);
        Array.Sort(sortB);
        for (int i = 0; i < a.Length; i++)
        {

            if (Math.Pow(sortA[i],2) != sortB[i])
            {
                return false;
            }
        }

        return true;
    }
}