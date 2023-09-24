#include <iostream>
#include <string>
#include <unordered_map>
int solution(std::string s) {
    std::unordered_map<char, int> romanMap = {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    int result = 0;
    int prev = 0;

    for (int i = s.length() - 1; i >= 0; i--) {
        int curr = romanMap[s[i]];
        if (curr >= prev) {
            result += curr;
        }
        else {
            result -= curr;
        }
        prev = curr;
    }

    return result;
}

int main() {
    std::cout << solution("MCMXC") << std::endl; // expected output: 1990
    std::cout << solution("MMVIII") << std::endl; // expected output: 2008
    std::cout << solution("MDCLXVI") << std::endl; // expected output: 1666

    return 0;
}