record Position(int X, int Y);


public class Day3
{
    public static void Main(string[] args)
    {
        string directions = File.ReadAllText("input.txt");
        // Console.WriteLine(directions);

        var visitedHouses = new Dictionary<Position, int>();


        var santaStart = new Position(0, 0);
        var roboStart = new Position(0, 0);
        // 2, since robo is also there
        visitedHouses[santaStart] = 2;

        //  x x
        // x x
        // 0123
        // ^>v<

        for (int idx = 0; idx < directions.Length; idx++)
        {
            if (idx % 2 == 0)
            {
                // Santa
            }
            else
            {
                // Robo.
            }
        }

        // Loop for santa
        for (int santaChoice = 0; santaChoice < directions.Length; santaChoice += 2)
        {
            var dir = directions[santaChoice];
            switch (dir)
            {
                case '^':
                    santaStart = santaStart with {Y = santaStart.Y + 1};
                    break;
                case 'v':
                    santaStart = santaStart with {Y = santaStart.Y - 1};
                    break;
                case '>':
                    santaStart = santaStart with {X = santaStart.X + 1};
                    break;
                case '<':
                    santaStart = santaStart with {X = santaStart.X - 1};
                    break;

            }
            if (visitedHouses.TryGetValue(santaStart, out int count))
            {
                visitedHouses[santaStart] = count + 1;
            }
            else
            {
                visitedHouses[santaStart] = 1;
            }
        }
        
        for (int roboChoice = 1; roboChoice < directions.Length; roboChoice += 2)
        {
            var dir = directions[roboChoice];
            switch (dir)
            {
                case '^':
                    roboStart = roboStart with {Y = roboStart.Y + 1};
                    break;
                case 'v':
                    roboStart = roboStart with {Y = roboStart.Y - 1};
                    break;
                case '>':
                    roboStart = roboStart with {X = roboStart.X + 1};
                    break;
                case '<':
                    roboStart = roboStart with {X = roboStart.X - 1};
                    break;

            }
            if (visitedHouses.TryGetValue(roboStart, out int count))
            {
                visitedHouses[roboStart] = count + 1;
            }
            else
            {
                visitedHouses[roboStart] = 1;
            }
        }

        // Result.
        Console.WriteLine(visitedHouses.Count);
    }
}


// Santa and Robo-Santa start at the same location (delivering two presents
// to the same starting house), then take turns moving based on instructions

// ^>v<
// (0/0) santa
// (0/0) robo-santa
// ^ -> 0/1  santa
// > -> 1/0  robo
// v -> 0/0  santa
// < -> 0/0  robo


