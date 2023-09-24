#include <iostream>
#include <string>
using namespace std;

int getCount(const string& inputStr) {
	int num_vowels = 0;
	char abc[] = { 'a', 'e', 'i','o','u'};
	for (int i = 0; i < inputStr.length(); i++)
	{
		for (int j = 0; j < 5; j++) {
			if (inputStr[i] == abc[j])
			{
				num_vowels++;
			}
		}
	}
	return num_vowels;
}

int main() {
	setlocale(LC_ALL, "russian");

	string text = "";
	getline(cin, text);
	
	cout<< getCount(text);
	return 0;
}