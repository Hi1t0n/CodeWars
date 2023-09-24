#include <iostream>

int summation(int num) {
	int sum = 0;
	for (int i = 1; i <= num; i++)
		sum += i;
	return sum;
}

int main()
{
    std::cout << summation(8);
}
