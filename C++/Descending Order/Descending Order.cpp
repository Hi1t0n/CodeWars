/*
* Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

Examples:
Input: 42145 Output: 54421

Input: 145263 Output: 654321

Input: 123456789 Output: 987654321

FUNDAMENTALS
*/
#include <iostream>
#include <Shlwapi.h>
#include <string>
#include <cinttypes>
uint64_t descendingOrder(uint64_t a)
{
    std::string str = std::to_string(a);
    for (int i = 0; i < str.length(); i++) {
        for (int j = 0; j < str.length() - 1; j++) {
            if ((int)str[j] < (int)str[j + 1]) {
                auto temp = str[j];
                str[j] = str[j + 1];
                str[j + 1] = temp;
            }
        }
    }
    return stoull(str);
}

int main()
{
    std::cout << descendingOrder(0)<<std::endl;
    std::cout << descendingOrder(123456789) << std::endl;
    std::cout << descendingOrder(1021) << std::endl;
    std::cout << descendingOrder(15) << std::endl;
    std::cout << descendingOrder(1235274488) << std::endl;
}