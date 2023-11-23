#include <iostream>
#include <fstream>

using namespace std;

int main() {
    int floor = 0;
    int charPos = 1;
    char n;
    fstream fileIn("input.txt", fstream::in);

    while (fileIn >> n)
    {
        
        if (n == '(') {
            floor++;
        } else if (n == ')')
        {
            floor--;
        }
        if (floor == -1)
        {
            cout << charPos << endl;
        }
        
        charPos++;
        
    }
    cout << floor << endl;
}