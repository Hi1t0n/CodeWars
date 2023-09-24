/*
* A hero is on his way to the castle to complete his mission. 
However, he's been told that the castle is surrounded with a couple of powerful dragons! 
each dragon takes 2 bullets to be defeated, our hero has no idea how many bullets he should carry.. 
Assuming he's gonna grab a specific given number of bullets and move forward to fight another specific 
given number of dragons, will he survive?

Return true if yes, false otherwise :)
*/
#include <iostream>

bool hero(int bullets, int dragons) {
    return dragons * 2 <= bullets ? true : false;
}

int main()
{
    std::cout << hero(10, 5);
    std::cout << hero(7, 4);
}

