using System;
using System.Collections.Generic;
using System.Linq;

namespace Categorize_New_Member
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var res = Kata.OpenOrSenior(
                new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } });
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }
    }
}

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i][0] >= 55 && data[i][1] > 7)
            {
                result.Add("Senior");
                continue;
            }
            result.Add("Open");
        }

        return result;
    }
}