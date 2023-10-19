using System.Text.RegularExpressions;

namespace Break_camelCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.BreakCamelCase("camelCase"));
        }
    }
}

public class Kata
{
    public static string BreakCamelCase(string str)
    {
        string res = "";
        string[] words = Regex.Split(str, "(?=\\p{Lu})");
        foreach (string word in words)
        {
            res += word + " ";
        }
        return res[..^1];

    }
}