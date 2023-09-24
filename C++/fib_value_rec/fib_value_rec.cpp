#include <iostream>

using namespace std;

unsigned long long int fib(int value)
{
    if (value == 0)
        return 0;
    if (value == 1 || value == 2)
        return 1;
    return fib(value - 1) + (value - 2);
}

int main()
{
    cout << fib(1000);
}
