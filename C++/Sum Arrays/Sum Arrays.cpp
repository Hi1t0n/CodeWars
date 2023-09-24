// Sum Arrays.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
#include <numeric>
int sum(std::vector<int> nums) {
    return std::accumulate(nums.begin(), nums.end(), 0);
}
int main()
{
    std::cout << sum({ 1, 2, -3, 3, 4 });
}

