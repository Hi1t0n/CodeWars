/*
* Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

Note: input will never be an empty string
*/
#include <iostream>
#include <string>
std::string fakeBin(std::string str) {
	for (int i = 0; i < str.length(); i++)
	{
		if(str[i] < '5')
			str[i] = '0';
		else
			str[i] = '1';
	}
	return str;
}
int main()
{
    std::cout << fakeBin("45385593107843568");
}

