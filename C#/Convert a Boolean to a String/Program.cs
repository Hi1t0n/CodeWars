namespace Convert_a_Boolean_to_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kata.BooleanToString(true));
        }
    }
}

public class kata
{
    public static string BooleanToString(bool b) => b.ToString();
}