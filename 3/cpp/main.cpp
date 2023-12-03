#include <iostream>
#include <fstream>
#include <unordered_set>



using namespace std;

//struct to hold x and y coordinates
struct coord
{
    int x;
    int y;
    //constructor
    coord(int x, int y) : x(x), y(y) {}   
    //overload == operator
    bool operator==(const coord& rhs) const
    {
        return x == rhs.x && y == rhs.y;
    }

};

//hash function for the struct
namespace std
{
    template<>
    struct hash<coord>
    {
        std::size_t operator()(const coord& k) const
        {
            //hash combine
            return std::hash<int>()(k.x) ^ (std::hash<int>()(k.y) << 1);
        }
    };
}

//function to update the position
coord updatePosition(coord curentPosition, char n)
{
    if (n == '<')
    {
        curentPosition.x--;
    }
    else if (n == '>')
    {
        curentPosition.x++;
    }
    else if (n == '^')
    {
        curentPosition.y++;
    }
    else if (n == 'v')
    {
        curentPosition.y--;
    }
    return curentPosition;
}

int main() {

    unordered_set <coord> houseVisits;
    char n;
    fstream fileIn("input.txt", fstream::in);
    // start from 0 0 for both of them
    auto santaPosition = coord(0, 0);
    auto robotPosition = coord(0, 0);

    houseVisits.insert(coord(0, 0));
    int i = 0;
    while (fileIn >> n)
    { 
        // if even Santa moves
        if (i % 2 == 0)
        {
            santaPosition = updatePosition(santaPosition, n);
            houseVisits.insert(santaPosition);
        }
        else // if odd RoboSanta moves
        {
            robotPosition = updatePosition(robotPosition, n);
            houseVisits.insert(robotPosition);
        }
        i++;    
    }
    cout << houseVisits.size() << endl;
}