#include <iostream>
#include <fstream>

using namespace std;

int main() {
    //always use fstream instead of ifstream
    fstream fileIn("input.txt", fstream::in);
}