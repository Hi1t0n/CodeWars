namespace Moving_Zeros_To_The_End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            foreach (int i in arr) { Console.WriteLine(i); }
        }
    }
}

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        int[] values = arr.Where(x => x != 0).ToArray();
        int[] zeroArray = arr.Where(x => x == 0).ToArray();

        return values.Concat(zeroArray).ToArray();
    }
}