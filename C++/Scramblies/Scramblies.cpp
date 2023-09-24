/*
Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

Notes:

Only lower case letters will be used (a-z). No punctuation or digits will be included.
Performance needs to be considered.
Examples
scramble('rkqodlw', 'world') ==> True
scramble('cedewaraaossoqqyt', 'codewars') ==> True
scramble('katas', 'steak') ==> False
*/
#include <iostream>
#include <string>
#include <algorithm>

bool scramble(const std::string& s1, const std::string& s2) {
	std::string s1_sort = s1;
	std::string s2_sort = s2;
	std::sort(s1_sort.begin(), s1_sort.end());
	std::sort(s2_sort.begin(), s2_sort.end());
	return std::includes(s1_sort.begin(), s1_sort.end(), s2_sort.begin(), s2_sort.end());
}

int main()
{
    std::cout << scramble("scriptjavx", "javascript");
	return 0;
}