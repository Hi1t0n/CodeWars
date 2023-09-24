/*
*/
#include <iostream>

class Transform {
public:
    static int operation(int a, int b);
};

int main()
{
    Transform a;
    std::cout << a.operation(1, 4);
}

int Transform::operation(int a, int b)
{
    int count = 0;
    while (a != b) 
    {
        if (a < b) {
            a *= 2;
            count++;
        }
        else if ((a - 1) % 2 == 0 && (a - 1) / 2 >= b) {
            a = (a - 1) / 2;
            count++;
        } 
        else {
            a /= 2;
            count++;
        }
    }
    return count;;
}
