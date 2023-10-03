/*
 Welcome.

In this kata you are required to, given a string, replace every letter with its position in the alphabet.

If anything in the text isn't a letter, ignore it and don't return it.

"a" = 1, "b" = 2, etc.

Example
Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" ( as a string )
 */

using System;

namespace Replace_With_Alphabet_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
        }
    }
}

public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        if(text is null) { return text; }
        text = text.ToLower();
        string positionInAlphabet = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] < 'a' || text[i] > 'z'){ continue; }
            positionInAlphabet += text[i] - 'a' + 1;
            if(i != text.Length - 1) { positionInAlphabet += ' '; }
        }
        return positionInAlphabet.Length > 0 && positionInAlphabet[positionInAlphabet.Length - 1] == ' ' ? positionInAlphabet[..^1] : positionInAlphabet;
    }
}