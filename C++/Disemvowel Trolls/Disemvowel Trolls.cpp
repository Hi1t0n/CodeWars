#include <string>
#include <iostream>

std::string disemvowel(const std::string& str)
{
	std::string str1 = str;
	std::string abc = "aAeEiIoOuU";
	for (int i = 0; i < str1.length(); i++)
	{
		for (int j = 0; j < abc.length(); j++)
		{
			if (str1[i] == abc[j])
			{
				str1.erase(i, 1);
				j = 0;
			}
		}
	}
	return str1;
}

int main()
{
	std::cout << disemvowel("I’m learning English");
}