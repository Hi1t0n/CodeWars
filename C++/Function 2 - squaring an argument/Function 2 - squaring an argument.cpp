// Now you have to write a function that takes an argument and returns the square of it.
#include <iostream>

template<typename T>

T square(T value) {
    return value * value;
}

int main()
{
    std::cout << square(5);
}

