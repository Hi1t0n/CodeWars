using System;
namespace Convert_a_string_to_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Solution.Solution.StringToArray("I love arrays they are my favorite");
            foreach (string word in words) { Console.WriteLine(word); }
        }
    }
}

namespace Solution
{
    public class Solution
    {
        public static string[] StringToArray(string str) => str.Split(' ');
    }
}