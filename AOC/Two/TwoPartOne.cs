namespace AOC.Two;

public static class TwoPartOne
{
    public static int Run()
    {
        var theList = new List<List<int>>();
        
        var sr = new StreamReader("Two/data.txt");
        var line = sr.ReadLine();
        
        while (line != null)
        {
            var split = line.Split(" ");
            theList.Add(split.Select(int.Parse).ToList());
            
            line = sr.ReadLine();
        }
        sr.Close();

        foreach (var aList in theList)
        {
            var length = aList.Count;
            
            
        }
        
        return 1;
    }
}