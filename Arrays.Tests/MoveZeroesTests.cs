using Xunit;

namespace Arrays.Tests;

public class MoveZeroesTests
{
    [Theory]
    [InlineData(new[] { 1, 3, 12, 0, 0 }, new[] { 0, 1, 0, 3, 12 })]
    [InlineData(new[] { 1 }, new[] { 1})]
    [InlineData(new[] { 0 }, new[] { 0 })]
    public void MoveZeroes_Do_Success(int[] expected, int[] arr)
    {
        var sut = new MoveZeroes();
        var actual = sut.Do(arr);
        
        Assert.Equal(expected, actual);
    }
}