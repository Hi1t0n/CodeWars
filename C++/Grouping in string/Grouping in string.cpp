/*
* In this kata you have to find whether same elements of the string are grouped together.

Example

Input	Output
112233	true
11223311	false

Explanation
In first example same elements are grouped together: (11)(22)(33), hence it should return true
In the second example there are two different groups of 1's: (11)2233(11), hence it should return false
*/
#include <iostream>
#include <string>
#include <algorithm>
#include <vector>
using namespace std;

bool find_func(const vector<char> vec, char ch) {
	if (vec.empty())
		return false;
	for (int i = 0; i < vec.size(); i++)
	{
		if (vec[i] == ch)
			return true;
	}
	return false;
}

bool isConsecutive(string s) {
	vector <char> vec;
	char prev = s[0];
	vec.push_back(prev);
	for (int i = 0; i < s.length(); i++)
	{
		if (s[i] != prev && !find_func(vec,s[i]))
		{
			prev = s[i];
			vec.push_back(prev);
		}
		else if(s[i] != prev && find_func(vec,s[i])) {
			return false;
		}
	}
	return true;
}

int main()
{
    std::cout << isConsecutive("1222334556667");
    std::cout << isConsecutive("11223311");
}

