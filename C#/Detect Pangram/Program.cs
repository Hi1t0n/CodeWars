﻿using System;
using System.Collections.Generic;
/*
 * A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
 * Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
 */
namespace Detect_Pangram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(Kata.IsPangram("AbCdEfGhIjKlM zYxWvUtSrQpOn"));
        }
    }
}

public static class Kata
{
    public static bool IsPangram(string str)
    {
        Dictionary<char, int> countLetter = new Dictionary<char, int>();
        
        foreach (char symbol in str.ToUpper())
        {
            if (char.IsLetter(symbol))
            {
                if (countLetter.ContainsKey(symbol))
                {
                    countLetter[symbol]++;
                }
                else
                {
                    countLetter.Add(symbol, 1);
                }
            }
        }

        return countLetter.Count == 26;
    }
}