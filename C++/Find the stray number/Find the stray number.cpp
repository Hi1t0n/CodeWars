// Find the stray number.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>

int stray(std::vector<int> numbers) {
	int  count = 0;
	for (int i = 1; i < numbers.size(); i++)
	{
		if (numbers[0] == numbers[i]) {
			count++;
		}
	}
	if (count != 0) {
		for (int i = 0; i < numbers.size(); i++)
		{
			if (numbers[0] != numbers[i])
				return numbers[i];
		}
	}
	else {
		return numbers[0];
	}
    return 0;
};

int main()
{
    std::cout << stray({ 1, 1, 2 });
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
