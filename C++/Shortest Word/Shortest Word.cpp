/*
* Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.
*/
#include <iostream>
#include <string>
int find_short(const std::string &str)
{
	std::istringstream inp(str);
	std::string s;
    int len = -1;
	while (std::getline(inp,s, ' '))
	{
		if (s.length() < len)
			len = s.length();
	}
	return len;
}

int main()
{
    std::cout << "Hello World!\n";
}