using Solution;

namespace Remove_String_Spaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpacesRemover.NoSpace("Ba nan fn f df ds fnndf nsdn n nfdnndsnf nf nn  nn n n "));
        }
    }
}

namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input) =>  input.Replace(" ", "");
    }
}