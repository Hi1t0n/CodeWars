using System;
//Find the total sum of internal angles (in degrees) in an n-sided simple polygon. N will be greater than 2.
namespace Sum_of_angles
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = Kata.Angle(5);
            Console.Write(a);
        }
    }
}

public class Kata
{
    public static int Angle(int n) => 180 * (n - 2);
}