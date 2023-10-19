using System.Text;

namespace Find_the_missing_letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
        }
    }
}

public class Kata
{
    public static char FindMissingLetter(char[] array)
    {
        char prevChar = array[0];
        char existChar;
        for (int i = 1; i < array.Length; i++)
        {
            existChar = array[i];
            int difference = (int)existChar - (int)prevChar;
            if (difference > 1) { break; }
            prevChar = existChar;
        }
        return Convert.ToChar((int)prevChar + 1);
    }
}