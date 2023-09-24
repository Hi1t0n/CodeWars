#include <iostream>
using namespace std;
long long factorial(int n) {
    return n > 0 ? n * factorial(n - 1) : 1;
}
/*
long long factorial(int n) {
    if (n < 0)
        return 0;
    else if (n == 0)
        return 1;
    return n * factorial(n-1);
}
*/
int main()
{
    std::cout << factorial(7);
}

