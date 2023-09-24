#include <iostream>
#include <string>
#include <cstring>
using namespace std;
std::string to_camel_case(std::string text) {
	if (text.length() != 0) {
		for (int i = 0; i < text.length() - 1; i++)
		{
			if (text[i] == '-' || text[i] == '_')
			{
				text[i + 1] = toupper(text[i + 1]);
			}
		}
		for (int i = 0; i < text.length(); i++)
		{
			if (text.find('-') != std::string::npos)
				text.erase(text.find('-'), 1);

			if (text.find('_') != std::string::npos)
				text.erase(text.find('_'), 1);
		}
		return text;
	}
	return "";
}

int main()
{
    std::cout << to_camel_case("a-Cat-is_evil");
}