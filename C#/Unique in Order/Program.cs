using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;

namespace Unique_In_Order
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var results = Kata.UniqueInOrder("AAAABBBCCDAABBB");
            foreach (var result in results)
            {
                Console.Write(result);
            }
        }
    }
}

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {

        var list = iterable?.ToList();
        if (list.Count == 0 || list is null)
        {
            return list;
        }

        if (list.Count == 1)
        {
            return list;
        }

        List<T> resultList = new List<T>();
        var currentElement = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (currentElement.Equals(list[i]))
            {
                continue;
            }
            else
            {
                resultList.Add(currentElement);
                currentElement = list[i];
            }
        }
        
        resultList.Add(currentElement);
        
        if (typeof(T) == typeof(char))
        {
            return new string(resultList.Cast<char>().ToArray()) as IEnumerable<T>; 
        }

        return resultList;
    }
}