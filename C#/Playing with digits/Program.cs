using System;
using System.Linq;

namespace Playing_with_digits
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DigPow.digPow(89,1));
            Console.WriteLine(DigPow.digPow(92,1));
            Console.WriteLine(DigPow.digPow(46288,3));
        }
    }
}

public class DigPow {
    public static long digPow(int n, int p)
    {
        string digitStr = n.ToString();
        double  resVal = 0;
        for (int i = 0; i < digitStr.Length; i++)
        {
            resVal += Math.Pow(int.Parse(digitStr[i].ToString()), p);
            p++;
        }

        return (long)resVal % n == 0 ? (long)resVal/n : -1;
    }
}