using System.Text;
using System;

namespace Credit_Card_Mask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Maskify("1234"));
            Console.WriteLine(Kata.Maskify("1234424243423424324244234423434323"));
        }
    }
}

public static class Kata
{
    // return masked string
    public static string Maskify(string cc)
    {
        if(cc.Length <= 4) { return cc; }

        string ccMaskSubString = cc.Substring(0, cc.Length - 4);

        StringBuilder stringBuilder = new StringBuilder(ccMaskSubString);

        for (int i = 0; i < ccMaskSubString.Length; i++) { stringBuilder[i] = '#'; }

        return string.Concat(stringBuilder.ToString(), cc.Substring(cc.Length - 4)); 
    }
}