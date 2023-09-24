using System;

namespace Beginner_Series__3_Sum_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

public class Sum
{
    public int GetSum(int a, int b)
    {
        int sum = 0;

        if(a == b) return a;

        if (a > b) for (int i = a; i>= b; i--) { sum += i; }

        else for(int i = a; i<= b;i++) { sum += i; }
        
        return sum;
    }
}