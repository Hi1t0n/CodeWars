namespace Next_bigger_number_with_the_same_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.NextBiggerNumber(513));
            Console.WriteLine(Kata.NextBiggerNumber(49424214));
        }
    }
}

public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        int[] digits = n.ToString().Select(x=> int.Parse(x.ToString())).ToArray();
        int pivotIndex = -1;
        for (int i = digits.Length-2; i >= 0; i--) 
        {
            if (digits[i] < digits[i+1])
            {
                pivotIndex = i;
                break;
            }
        }
        if (pivotIndex is -1) { return  pivotIndex; }

        int swapIndex = -1;
        for(int i = digits.Length-1; i >= 0; i--) 
        {
            if (digits[i] > digits[pivotIndex])
            {
                swapIndex = i;
                break;
            }
        }

        int temp = digits[pivotIndex];
        digits[pivotIndex] = digits[swapIndex];
        digits[swapIndex] = temp;
        Array.Sort(digits, pivotIndex + 1, digits.Length - pivotIndex - 1);
        long result = long.Parse(string.Join("",digits));
        return result > n ? result : -1;
    }
}