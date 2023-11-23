#include <iostream>
#include <fstream>

using namespace std;

int main() {
    int floor = 0;
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
    }
    cout << floor << endl;
}