string input =  File.ReadAllText("input.txt");
int floor = 0;

foreach (var c in input)
{
    if (c == '(')
    {
        floor++;
    }
    else
    {
        floor--;
    }
}

Console.WriteLine($"{floor}");