/*
* In this kata, 
you need to write a function that takes a string and a letter as input and then returns the index of the second occurrence of that letter in the string. 
If there is no such letter in the string, then the function should return -1. If the letter occurs only once in the string, then -1 should also be returned.
*/
#include <iostream>
#include <string>

int secondSymbol(const std::string& str, char symbol) {
    int count = 0;
    for (int i = 0;i < str.length();i++)
    {
        if (str[i] == symbol)
            count++;
        if (count == 2)
            return i;
    }
    return -1;
}


int main()
{
    std::cout << "Hello World!\n";
}
