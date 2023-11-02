using System;

namespace Persistent_Bugger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Persist.Persistence(39));
            Console.WriteLine(Persist.Persistence(999));
        }
    }
}

public class Persist 
{
    public static int Persistence(long n)
    {
        string str = n.ToString();
        int val = 1;
        int count = 0;
        while (str.Length != 1)
        {
            for (int i = 0; i < str.Length; i++)
            {
                val *= int.Parse(str[i].ToString());
            }
            str = val.ToString();
            val = 1;
            count++;
        }

        return count;
    }
}