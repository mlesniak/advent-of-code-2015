string input = File.ReadAllText("input.txt");
int floor = 0;

// Part 1:
// foreach (var c in input)
// {
//     if (c == '(')
//     {
//         floor++;
//     }
//     else
//     {
//         floor--;
//     }
// }
//
// Console.WriteLine($"{floor}");

// Part 2:
for (var i = 0; i < input.Length; i++)
{
    var c = input[i];
    if (c == '(')
    {
        floor++;
    }
    else
    {
        floor--;
    }
    if (floor == -1)
    {
        // Positions start at 1, but
        // characters are indexed at 0.
        Console.WriteLine(i + 1);
        break;
    }
}
