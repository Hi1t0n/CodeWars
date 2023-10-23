using System.Collections;
using System;

namespace Bit_Counting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.CountBits(1234));   
        }
    }
}



public class Kata
{
    public static int CountBits(int n)
    {
        string bitVal = Convert.ToString(n,2);
        int count = 0;
        foreach (char c in bitVal) { if(c == '1') { count++; } }
        return count;
    }
}