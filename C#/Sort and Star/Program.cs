using System;
using System.Text;

namespace Sort_and_Star
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.TwoSort(new [] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps"}));
        }
    }
}

public class Kata
{
    public static string TwoSort(string[] s)
    {
        Array.Sort(s, (x, y) =>
        {
            int result = x[0].CompareTo(y[0]);
            if (result == 0)
            {
                result = x.Length.CompareTo(y.Length);
            }

            return result;
        });
        string str = s[0];
        StringBuilder strBuild = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if (i == str.Length - 1)
            {
                strBuild.Append($"{str[i]}");
                break;
            }
            strBuild.Append($"{str[i]}***");
        }
        return strBuild.ToString();
    }  
}