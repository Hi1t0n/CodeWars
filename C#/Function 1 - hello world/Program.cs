using System;
using System.Runtime.ConstrainedExecution;

namespace Function_1___hello_world
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.greet());
        }
    }
}

public static class Kata
{
    public static string greet() => "hello world!";
}