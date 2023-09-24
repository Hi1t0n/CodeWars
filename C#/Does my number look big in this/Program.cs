using System;

namespace Does_my_number_look_big_in_this
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool res = Kata.Narcissistic(371);
            
            Console.WriteLine(res);
        }
    }
}

public class Kata
{
    public static bool Narcissistic(int value)
    {
        string strValue = value.ToString();
        double sum = 0;
        for (int i = 0;i<strValue.Length; i++) { sum += Math.Pow(int.Parse(strValue[i].ToString()), strValue.Length); }

        return sum == value ? true : false;
    }
}