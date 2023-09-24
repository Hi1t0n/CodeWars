/*
* Given a non-empty array of integers, return the result of multiplying the values together in order. 
*
* Example: [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
*/
#include <vector>
#include <iostream>

using namespace std;

int grow(vector<int> nums)
{
    int a = 1;
    for (int i = 0; i < nums.size(); i++)
    {
        int value = nums[i];
        a = a * value;
    }
    return a;
}

int main()
{
    vector<int>nums = { 1, 2, 3 };
    cout << grow(nums) << endl;
}
