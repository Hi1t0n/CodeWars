using System;
namespace Remove_First_and_Last_Character_Part_Two
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.Array("1,2,3"));
        }
    }
}

public static class Kata
{
    public static string Array(string s)
    {
        if (s.Length <= 2) return null;
        string[] arr = s.Split(',');
        if (arr.Length <= 2) return null;
        return string.Join(" ", arr, 1, arr.Length - 2);
    }
}