/*
 Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
 */


namespace Your_order__please
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Order("is2 Thi1s T4est 3a"));
        }
    }


    public static class Kata
    {
      public static string Order(string words)
      {
            if (words.Length == 0) return words;
            string[] _words = words.Split(' ');
            char[] numbers = {'1','2','3','4','5','6','7','8','9'};
            string res = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < _words.Length; j++) 
                {
                    if (_words[j].Contains(numbers[i]))
                    {
                        res += _words[j] + " ";
                        break;
                    }
                }
                if (i == _words.Length) { break; }
            }
            return res[..^1];
            
      }
    }
}