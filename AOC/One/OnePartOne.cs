namespace AOC.One;

public static class OnePartOne
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

        firstList.Sort();
        secondList.Sort();

        var firstQueue = new Queue<int>(firstList);
        var secondQueue = new Queue<int>(secondList);

        var result = new List<int>();

        while (firstQueue.Count > 0)
        {
            result.Add(Math.Abs(firstQueue.Dequeue() - secondQueue.Dequeue()));
        }

        return result.Sum();
    }
}