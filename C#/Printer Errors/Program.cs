using System;
using System.Collections.Generic;
namespace Printer_Errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Printer.PrinterError("aaaxbbbbyyhwawiwjjjwwm"));
        }
    }
}

public class Printer
{
    public static string PrinterError(String s)
    {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        char[] letters = new char[13];
        int currentPrintSymbols = 0;
        for (int i = 0; i < 13; i++)
        {
            letters[i] = (char)('a' + i);
        }

        foreach (char c in s) 
        {
            if (dict.ContainsKey(c))
            {
                int currentValue = dict[c];
                currentValue++;
                dict[c] = currentValue;
            }
            else
            {
                dict.Add(c, 1);
            }
        }

        foreach(char c in letters)
        {
            if (dict.TryGetValue(c,out int value)) { currentPrintSymbols += value; }
        }
        return $"{s.Length - currentPrintSymbols}/{s.Length}";
    }
}