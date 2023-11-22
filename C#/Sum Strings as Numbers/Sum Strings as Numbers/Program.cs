using System;
using System.Data.SqlTypes;
using System.Numerics;
namespace Sum_Strings_as_Numbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        BigInteger BigInt1;
        BigInteger BigInt2;

        BigInteger.TryParse(a, out BigInt1);
        BigInteger.TryParse(b, out BigInt2);

        return (BigInt1 + BigInt2).ToString();

    }
}