/*
Gigi is a clever monkey, living in the zoo, his teacher (animal keeper) recently taught him some knowledge of "0".

In Gigi's eyes, "0" is a character contains some circle(maybe one, maybe two).

So, a is a "0",b is a "0",6 is also a "0"，and 8 have two "0" ,etc...

Now, write some code to count how many "0"s in the text.

Let us see who is smarter? You ? or monkey?

Input always be a string(including words numbers and symbols)，You don't need to verify it, but pay attention to the difference between uppercase and lowercase letters.

Here is a table of characters：

one zero	abdegopq069DOPQR         () <-- A pair of braces as a zero
two zero	%&B8
Output will be a number of "0".
*/
#include <iostream>
#include <string>

using namespace std;

int countZero(std::string s)
{
    int count = 0;
    string one_zero = "abdegopq069DOPQR";
    string two_zero = "%&B8";
    for (int i = 0; i < s.length(); i++)
    {
        if (s[i] == '(' && s[i + 1] == ')') {
            count++;
        }
        for (int j = 0; j < one_zero.length(); j++)
        {
            if (s[i] == one_zero[j]) {
                count++;
            }
        }
        for (int j = 0; j < two_zero.length(); j++)
        {
            if (s[i] == two_zero[j]) {
                count += 2;
            }
        }
    }
    return count;
}

int main()
{
    cout << countZero("abcdefghijklmnopqrstuvwxyz");
}
