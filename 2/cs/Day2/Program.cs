string[] lines = File.ReadAllLines("input.txt");
var sum = 0;

foreach (string line in lines)
{
    int[] lwh = line.Split("x").Select(Int32.Parse).ToArray();
    // int l = lwh[0];
    // int w = lwh[1];
    // int h = lwh[2];
    // int paper = 2 * l * w + 2 * w * h + 2 * l * h;
    // int extra = Math.Min(l * w, Math.Min(w * h, l * h));
    // sum += (paper + extra);

    Array.Sort(lwh);
    int ribbon = lwh[0] * 2 + lwh[1] * 2;
    int bow = lwh[0] * lwh[1] * lwh[2];
    sum += (ribbon + bow);
}

Console.WriteLine(sum);