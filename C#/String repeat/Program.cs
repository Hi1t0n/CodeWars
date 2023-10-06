namespace String_repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.Program.RepeatStr(3,"aa"));
        }
    }
}

namespace Solution
{
    public static class Program
    {
        public static string RepeatStr(int n, string s)
        {
            return string.Join("",Enumerable.Repeat(s, n));
        }
    }
}