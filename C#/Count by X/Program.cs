namespace Count_by_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] res = Kata.CountBy(2, 5);
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
        }
    }
}

public static class Kata
{
    public static int[] CountBy(int x, int n)
    {
        int[] res = new int[n];
        for (int i = x, j = 0 ; j < n; i += x,j++)
        {
            res[j] = i;
        }

        return res;
    }
}