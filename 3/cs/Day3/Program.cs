record Position(int X, int Y);


public class Day3
{
    public static void Main(string[] args)
    {
        string directions = File.ReadAllText("input.txt");
        // Console.WriteLine(directions);

        var visitedHouses = new Dictionary<Position, int>();
        var start = new Position(0, 0);
        visitedHouses[start] = 1;
        foreach (var dir in directions)
        {
            // Console.WriteLine(dir);
            switch (dir)
            {
                case '^':
                    start = start with {Y = start.Y + 1};
                    break;
                case 'v':
                    start = start with {Y = start.Y - 1};
                    break;
                case '>':
                    start = start with {X = start.X + 1};
                    break;
                case '<':
                    start = start with {X = start.X - 1};
                    break;

            }
            if (visitedHouses.TryGetValue(start, out int count))
            {
                visitedHouses[start] = count + 1;
            }
            else
            {
                visitedHouses[start] = 1;
            }
        }

        // foreach (var house in visitedHouses)
        // {
        //     Console.WriteLine(house);
        // }

        Console.WriteLine(visitedHouses.Count);
    }
}
