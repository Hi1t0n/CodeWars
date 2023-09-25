/*
 Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.
 */

namespace Shortest_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.FindShort("String will never be empty and you do not need to account for different data types")
        }
    }
}

public class Kata
{
    public static int FindShort(string s)
    {
        string[] Words = s.Split(' ');
        Array.Sort(Words, (x,y) => x.Length.CompareTo(y.Length));
        return Words[0].Length;
    }
}