using System;
using System.Runtime.ConstrainedExecution;

namespace Sum_The_Strings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Solution.Program.StringsSum("1","2"));
            Console.WriteLine(Solution.Program.StringsSum("",""));
        }
    }
}

namespace Solution
{
    public static class Program
    {
        public static string StringsSum(string s1, string s2)
        {
            if (s1.Length == 0) {s1 = "0";}
            if (s2.Length == 0) {s2 = "0";}
            return (int.Parse(s1) + int.Parse(s2)).ToString();
        }
    }
}