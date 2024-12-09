namespace AOC.Two;

public static class TwoPartTwo
{
    public static int Run(List<List<int>>? input = null)
    {
        var safeReports = 0;
        
        foreach (var measurementSet in input ?? ExtractMeasurementData())
        {
            var isIncreasing = measurementSet[0] < measurementSet[0+1];
            var isUnSafeCount = 0;
            
            for (var i = 0; i < measurementSet.Count -1; i++)
            {
                var current = measurementSet[i];
                var next = measurementSet[i + 1];
                
                var creaseCorrectly = isIncreasing 
                    ? current < next 
                    : current > next;
                
                var levelingCorrectly = Math.Abs(current - next) is > 0 and < 4;

                if (!creaseCorrectly || !levelingCorrectly)
                {
                    isUnSafeCount += 1;
                }
            }
            
            if(isUnSafeCount < 2) safeReports += 1;
        }
        
        return safeReports;
    }

    private static List<List<int>> ExtractMeasurementData()
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
        return theList;
    }
}