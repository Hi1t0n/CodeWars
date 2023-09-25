/*
    The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

Examples
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 
Notes
Assertion messages may be unclear about what they display in some languages. If you read "...It Should encode XXX", the "XXX" is the expected result, not the input! 

 */
using System;
using System.Collections;
using System.Text;

namespace Duplicate_Encoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.DuplicateEncode("din"));
            Console.WriteLine(Kata.DuplicateEncode("Success"));
        }
    }
}

public class Kata
{
    public static string DuplicateEncode(string word)
    {
        Hashtable symbols = new Hashtable();
        word = word.ToLower();
        StringBuilder _word = new StringBuilder();
        for (int i = 0;i < word.Length; i++)
        {
            if (symbols.ContainsKey(word[i]))
            {
                int currentValue = (int)symbols[word[i]];
                symbols[word[i]] = currentValue + 1;
            }
            else { symbols.Add(word[i], 1); }
        }

        for (int i = 0; i < word.Length;i++)
        {
            if ((int)symbols[word[i]] > 1)
            {
                _word.Append(')');
            } else { _word.Append('('); }
        }

        return _word.ToString();
    }
}