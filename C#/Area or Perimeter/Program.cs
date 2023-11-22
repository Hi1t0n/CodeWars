using System;

namespace Area_or_Perimeter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}

public class MathCheck
{
    public static int AreaOrPerimeter(int l, int w) => l == w ? l * w : (l * 2) + (w * 2);
}