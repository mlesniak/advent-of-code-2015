record Position(int X, int Y);


public class Day3
{
    public static void Main(string[] args)
    {
        string directions = File.ReadAllText("input.txt");

        var visitedHouses = new Dictionary<Position, int>();

        var santaStart = new Position(0, 0);
        var roboStart = new Position(0, 0);
        // 2, since both robo and santa visit the first house.
        visitedHouses[santaStart] = 2;

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
            santaStart = ComputeNewPosition(dir, santaStart);
            UpdateHouseCount(visitedHouses, santaStart);
        }
       
        // Loop for robot.
        for (int roboChoice = 1; roboChoice < directions.Length; roboChoice += 2)
        {
            var dir = directions[roboChoice];
            roboStart = ComputeNewPosition(dir, roboStart);
            UpdateHouseCount(visitedHouses, roboStart);
        }

        // Result.
        Console.WriteLine(visitedHouses.Count);
    }

    private static void UpdateHouseCount(Dictionary<Position, int> visitedHouses, Position position)
    {
        if (visitedHouses.TryGetValue(position, out int count))
        {
            visitedHouses[position] = count + 1;
        }
        else
        {
            visitedHouses[position] = 1;
        }
    }

    private static Position ComputeNewPosition(char dir, Position position)
    {
        switch (dir)
        {
            case '^':
                position = position with {Y = position.Y + 1};
                break;
            case 'v':
                position = position with {Y = position.Y - 1};
                break;
            case '>':
                position = position with {X = position.X + 1};
                break;
            case '<':
                position = position with {X = position.X - 1};
                break;
        }
        return position;
    }
}




