namespace AOC.One;

public static class OnePartTwo
{
    public static int Run()
    {
        var firstList = new List<int>();
        var secondList = new List<int>();
        
        var sr = new StreamReader("One/data.txt");
        var line = sr.ReadLine();
        
        while (line != null)
        {
            var split = line.Split("   ");
            firstList.Add(int.Parse(split[0].Trim()));
            secondList.Add(int.Parse(split[1].Trim()));
            line = sr.ReadLine();
        }
        sr.Close();

        var result = firstList.Select(i => i * secondList.Count(x => x == i)).ToList();

        return result.Sum();
    }
}