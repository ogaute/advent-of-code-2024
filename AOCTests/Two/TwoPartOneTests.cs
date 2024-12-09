
using AOC.Two;
using FluentAssertions;

namespace AOCTests.Two;

public class TwoPartOneTests
{
    [Theory]
    [InlineData(new[] {1, 2, 3}, 1)]
    [InlineData(new[] {3, 2, 1}, 1)]
    [InlineData(new[] {1, 2, 1}, 0)]
    [InlineData(new[] {2, 1, 2, 1, 2}, 0)]
    [InlineData(new[] {1, 1, 5}, 0)]
    [InlineData(new[] {10, 1, 5}, 0)]
    public void Test1(int[] data, int expectedSafe)
    {
        var dataSet = new List<List<int>> { data.ToList() };

        TwoPartOne.Run(dataSet).Should().Be(expectedSafe);
    }
}