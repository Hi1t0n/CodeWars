#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int findSmallest(vector <int> list)
{
    return *min_element(list.begin(), list.end());
}
int main()
{
    std::cout << findSmallest({ -23,12,0,-47,-3,24 });
}

