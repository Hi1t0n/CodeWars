namespace Sum_of_two_lowest_positive_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.sumTwoSmallestNumbers(new int[] { 2,4,1,3,2,1,78,567,46,2,62,653});
        }
    }
}

public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        numbers = numbers.OrderBy(x => x).ToArray();
        return numbers[0]+numbers[1];
    }
}