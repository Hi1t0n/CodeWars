#include <vector>
#include <iostream>

unsigned long long int sum_factorial(std::vector<int> vi);
long long factorial(int n);

int main() {
	std::cout << sum_factorial({ 4, 5, 1 });
}

unsigned long long int sum_factorial(std::vector<int> vi) {
	long long sum = 0;
	for (int el : vi) {
		sum += factorial(el);
	}
	return sum;
}

long long factorial(int n) {
	return n > 0 ? n * factorial(n - 1) : 1;
}