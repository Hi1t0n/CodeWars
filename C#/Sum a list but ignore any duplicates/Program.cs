using System;
using System.Collections.Generic;

namespace Sum_a_list_but_ignore_any_duplicates
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.SumNoDuplicates(new int[]{3,4,3,6}));
        }
    }
}

public class Kata
{
    public static int SumNoDuplicates(int[] arr)
    {
        int result = 0;
        Dictionary<int, int> values = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (values.ContainsKey(arr[i]))
            {
                values[arr[i]]++;
                continue;
            }
            values.Add(arr[i],1);
        }

        foreach (var value in values)
        {
            if (value.Value != 1)
            {
                continue;
            }

            result += value.Key;
        }
        return result;
    }
}