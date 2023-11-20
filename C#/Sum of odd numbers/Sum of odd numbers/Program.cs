using System;
/*
 * Given the triangle of consecutive odd numbers:

             1
          3     5
       7     9    11
   13    15    17    19
21    23    25    27    29
...
Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)

1 -->  1
2 --> 3 + 5 = 8
 */
namespace Sum_of_odd_numbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(Kata.RowSumOddNumbers(42));
        }
    }
}

public static class Kata
{
    public static long RowSumOddNumbers(long n) // Math.Pow(n,3)
    {
        int rowSum = 0;
        int startNumber = 1;

        for (int i = 0; i < n; i++)
        {
            rowSum += startNumber;
            startNumber += 2;
        }

        return rowSum * n;
    }
}