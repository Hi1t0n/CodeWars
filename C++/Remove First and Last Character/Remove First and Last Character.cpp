/*
* It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string. 
* You're given one parameter, the original string. You don't have to worry with strings with less than two characters.
*/
#include <iostream>
#include <string>

using namespace std;

string sliceString(string str)
{
    str.erase(0, 1);
    str.erase(str.length()-1, 1);
    return str;
}


int main()
{
    std::cout << sliceString("ABCD");
}

