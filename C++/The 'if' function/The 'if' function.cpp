/*
* Create a function called _if which takes 3 arguments: a value bool and 2 functions (which do not take any parameters): func1 and func2
*
* When bool is truthy, func1 should be called, otherwise call the func2.
*/
#include <iostream>
#include <string>

using namespace std;

void func1()
{ 
	cout << "true"; 
}
void func2()
{ 
	cout << "false"; 
}
void _if(bool value, std::function<void(void)> func1, std::function<void(void)> func2)
{
	value ? func1() : func2();
}

int main()
{
	_if(true);
    return 0;
}
