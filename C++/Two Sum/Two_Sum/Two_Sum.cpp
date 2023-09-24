#include <iostream>
#include <vector>
using namespace std;
vector <int> twosum(const std::vector<int>& numbers, int target)
{
    for (int i = 0; i < numbers.size()-1; i++)
    {
        for (int j = i + 1; j < numbers.size(); j++) {
            if (numbers[i] + numbers[j] == target)
            {
                return {i ,j};
            }
        }
    }
    return {};
}

int main()
{
    vector<int>nums = { 1, 2, 3 };
    int target = 14690;
    //twosum({ 1234, 5678, 9012 }, 14690);
    for (int &x : twosum({ 1234, 5678, 9012 }, target))
    {
        cout << x << endl;
    }
    return 0;
}
