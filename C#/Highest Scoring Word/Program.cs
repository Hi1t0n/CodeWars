/*
 Given a string of words, you need to find the highest scoring word.

Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.

For example, the score of abad is 8 (1 + 2 + 1 + 4).

You need to return the highest scoring word as a string.

If two words score the same, return the word that appears earliest in the original string.

All letters will be lowercase and all inputs will be valid.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Highest_Scoring_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.High("man i need a taxi up to ubud"));
        }
    }
}

public class Kata
{
    public static string High(string s)
    {
        string[] words = s.Split(' ');
        Dictionary<string, int> scoreWords = new Dictionary<string, int>();
        int scoreWord = 0;
        foreach(string word in words)
        {
            if (scoreWords.ContainsKey(word)) { continue; }
            foreach(char letter in word)
            {
                int indexInAlphabet = (int)letter % 32;
                scoreWord += indexInAlphabet;
            }
            scoreWords.Add(word, scoreWord);
            scoreWord = 0;
            
        }
        return scoreWords.OrderByDescending(x => x.Value).First().Key;
    }
}