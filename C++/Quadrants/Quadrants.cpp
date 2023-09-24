#include <iostream>

int quadrant(int x, int y) {
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else
        return 4;
}

int main()
{
    std::cout << quadrant(-10, 100)<<std::endl;
    std::cout << quadrant(1, 2) << std::endl;
    std::cout << quadrant(-1, -9) << std::endl;
    std::cout << quadrant(19, -56) << std::endl;
}
