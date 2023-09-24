/*
* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
* Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).
*/
#include <iostream>
using namespace std;
int solution(int number)
{
	if (number < 0)
	{
		return 0;
	}
	int sum = 0;
	for (int i = 1; i < number; i++)
	{
		if(i < number)
		{
			if (i % 3 == 0 or i % 5 == 0)
			{
				sum += i;
			}
		}
	}
	return sum;
}


int main()
{
	int number;
	cin >> number;
	cout << solution(number);
}


