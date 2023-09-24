// String ends with.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <algorithm>
bool solution(std::string const& str, std::string const& ending) {
	if (str.length() < ending.length())
		return false;
	if (str.substr(str.length() - ending.length(), ending.length()) == ending)
		return true;
	return false;
}
int main()
{
	std::cout << solution("abcde", "cde") << std::endl;
	std::cout << solution("abcde", "abc") << std::endl;
	std::cout << solution("abc", "d") << std::endl;
	std::cout << solution("abc", "") << std::endl;
}
