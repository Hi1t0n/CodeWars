/*
 Write a function that takes an array of strings as an argument and returns a sorted array containing the same strings, ordered from shortest to longest.

For example, if this array were passed as an argument:

["Telescopes", "Glasses", "Eyes", "Monocles"]

Your function would return the following array:

["Eyes", "Glasses", "Monocles", "Telescopes"]

All of the strings in the array passed to your function will be different lengths, so you will not have to decide how to order multiple strings of the same length.
*/
#include <iostream>
#include <vector>
#include <algorithm>
class Kata
{
public:
    std::vector<std::string> sortByLength(std::vector<std::string> array)
    {
        std::sort(array.begin(), array.end(), [](std::string const& str1, std::string const& str2) {return str1.size() < str2.size(); });
        return array;
    }

};
/*
class Kata
{
public:
    std::vector<std::string> sortByLength(std::vector<std::string> array)
    {
        for (int i = 0; i < array.size(); i++)
        {
            for (int j = 0; j < array.size()-1; j++)
            {
                if (array[j].length() > array[j + 1].length()) {
                    auto temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }


            }
        }
        return array;
    }
};
*/