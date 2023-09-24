/*
Your goal is to implement the method meanVsMedian which accepts an odd-length array of integers and returns one of the following:

'mean' - in case mean value is larger than median value
'median' - in case median value is larger than mean value
'same' - in case both mean and median share the same value
Reminder: Median

Array will always be valid (odd-length >= 3)
*/
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;
std::string meanVsMedian(std::vector<int> numbers)
{
    sort(numbers.begin(), numbers.end());
    float average = 0;
    for (auto it = numbers.begin(); it != numbers.end(); ++it)
        average += *it;
    average /= numbers.size();
    double median = numbers[(numbers.size() / 2)];
    if (average == median)
        return "same";
    return average > median ? "mean" : "median";
}

int main()
{
    cout<< meanVsMedian({ 1, 1, 1 });
}

