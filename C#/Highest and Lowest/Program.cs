using System;
using System.Collections.Generic;

namespace Highest_and_Lowest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.HighAndLow("1 2 3 4 5"));
        }
    }
}


public static class Kata
{
    public static string HighAndLow(string numbers)
    {

        string[] numbersString = numbers.Split(' ');
        List <int >numbersList = new List <int > ();
        for (int i = 0;i<numbersString.Length;i++)
        {
            numbersList.Add(Convert.ToInt32(numbersString[i]));
        }
        numbersList.Sort();


        return $"{numbersList[numbersList.Count-1] + " " + numbersList[0]}";
    }
}