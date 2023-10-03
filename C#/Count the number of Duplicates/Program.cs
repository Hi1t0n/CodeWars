/*
 Count the number of Duplicates
Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

Example
"abcde" -> 0 # no characters repeats more than once
"aabbcde" -> 2 # 'a' and 'b'
"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
"indivisibility" -> 1 # 'i' occurs six times
"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
"aA11" -> 2 # 'a' and '1'
"ABBA" -> 2 # 'A' and 'B' each occur twice
 */

using System;
using System.Collections.Generic;

namespace Count_the_number_of_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.DuplicateCount("aaBBCaAAGHBEJKVOKOENGBFEJKNKLQOWERRTREDGRDCGRDFVGRDC"));
        }
    }
}

public class Kata
{
    public static int DuplicateCount(string str)
    {
        if(str is null) { return -1; }
        str = str.ToLower();
        Dictionary<char,int> countLetter = new Dictionary<char,int>();
        foreach(char letter in str)
        {
            if (countLetter.ContainsKey(letter)) 
            { 
                countLetter[letter]++;
                continue;
            }
            countLetter.Add(letter, 1);
        }
        
        int count = 0;
        foreach(var letter in countLetter) {if(letter.Value > 1) { count++; } }
        return count;
    }
}