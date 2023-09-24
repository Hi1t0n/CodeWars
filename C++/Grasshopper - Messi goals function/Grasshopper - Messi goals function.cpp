#include <iostream>

int goals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals) {
    return laLigaGoals + copaDelReyGoals + championsLeagueGoals;
}

int main()
{
    std::cout << goals(50,2,123);
}