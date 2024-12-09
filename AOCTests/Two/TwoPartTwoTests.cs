
using AOC.Two;
using FluentAssertions;

namespace AOCTests.Two;

public class TwoPartTwoTests
{
    [Theory]
    [InlineData(new[] {1, 2, 3}, 1)]
    [InlineData(new[] {3, 2, 1}, 1)]
    [InlineData(new[] {1, 2, 1}, 1)]
    [InlineData(new[] {1, 3, 1, 2, 1}, 0)]
    public void Test1(int[] data, int expectedSafe)
    {
        var dataSet = new List<List<int>> { data.ToList() };

        TwoPartTwo.Run(dataSet).Should().Be(expectedSafe);
    }
}