#include <iostream>
#include <fstream>

using namespace std;


// 2*l*w + 2*w*h + 2*h*l

//A present with dimensions 2x3x4 requires 2*6 + 2*12 + 2*8 = 52 square feet 
//of wrapping paper plus 6 square feet of slack, for a total of 58 square feet.
//A present with dimensions 1x1x10 requires 2*1 + 2*10 + 2*10 = 42 square feet 
//of wrapping paper plus 1 square foot of slack, for a total of 43 square feet.


int main() {

    fstream fileIn("input.txt", fstream::in);
    int totalArea = 0;
    // read all dimension from file
    std::string n;
    while (fileIn >> n)
    {
        // there should be only 2 x
        auto firstX = n.find('x');
        auto secondX = n.find('x', firstX + 1);
        
        auto l = std::stoi(n.substr(0, firstX));
        auto w = std::stoi(n.substr(firstX + 1, secondX));
        auto h = std::stoi(n.substr(secondX + 1, n.length()));

        //cout << l << " " << w << " " << h << endl;
        // 2*l*w + 2*w*h + 2*h*l
        auto first = l*w;
        auto second = w*h;
        auto third = h*l;

        int packetArea = 2*first + 2*second + 2*third;
        if (first <= second && first <= third)
        {
            packetArea += first;
        }
        else if (second <= first && second <= third)
        {
            packetArea += second;
        }
        else if (third <= first && third <= second)
        {
            packetArea += third;
        }

        totalArea += packetArea;
    }
    cout << totalArea << endl;
}