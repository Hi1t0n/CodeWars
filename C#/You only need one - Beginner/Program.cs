/*
 You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.

Array can contain numbers or strings. X can be either.

Return true if the array contains the value, false if not.
 */
using System;
using System.Linq;
namespace You_only_need_one___Beginner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Check(new object[] { "what", "a", "great", "kata" }, "kat"));
            Console.WriteLine(Kata.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
        }
    }
}

public class Kata
{
    public static bool Check(object[] a, object x) => a.Contains(x);

}