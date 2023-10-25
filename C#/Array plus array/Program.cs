namespace Array_plus_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
        }
    }
}

public static class Kata
{
    public static int ArrayPlusArray(int[] arr1, int[] arr2) => arr1.Sum() + arr2.Sum();
}