using System;
using System.Xml.Linq;

namespace Are_You_Playing_Banjo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

public class Kata
{
    public static string AreYouPlayingBanjo(string name) => name[0].ToString().ToLower() is "r" ? $"{name} plays banjo" : $"{name} does not play banjo";
}
