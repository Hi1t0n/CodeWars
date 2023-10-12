/*
 Build Tower
Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

For example, a tower with 3 floors looks like this:

[
  "  *  ",
  " *** ", 
  "*****"
]
And a tower with 6 floors looks like this:

[
  "     *     ", 
  "    ***    ", 
  "   *****   ", 
  "  *******  ", 
  " ********* ", 
  "***********"
]
Go challenge Build Tower Advanced once you have finished this :)
 */
namespace Build_Tower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] res = Kata.TowerBuilder(5);
            foreach (string s in res) { Console.WriteLine(s); }
        }
    }
}

public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        int spaceBarValue = nFloors - 1;
        string[] result = new string[nFloors];
        int symbolValue = 1;
        for (int i = 0; i< nFloors;i++) 
        {
            string symbol = new string('*', symbolValue);
            string spaceBar = new string(' ', spaceBarValue);
            result[i] = spaceBar + symbol + spaceBar;
            spaceBarValue--;
            symbolValue += 2 ;
        }

        return result;
    }
}