using System;
namespace Convert_a_String_to_a_Number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.StringToNumber("1405"));
            Console.WriteLine(Kata.StringToNumber("77"));
            Console.WriteLine(Kata.StringToNumber("-7"));
        }
    }
}


public class Kata
{
    public static int StringToNumber(String str) => Int32.Parse(str);
}