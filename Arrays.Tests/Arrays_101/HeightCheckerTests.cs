using Xunit;

namespace Arrays.Tests;

public class HeightCheckerTests
{
    [Theory]
    [InlineData(3, new int[]{1,1,4,2,1,3})]
    [InlineData(5, new int[]{5,1,2,3,4})]
    [InlineData(0, new int[]{1,2,3,4,5})]
    public void HeightChecker_Do_Success(int expected, int[] height)
    {
        var sut = new HeightChecker();
        var actual = sut.Do(height);
        
        Assert.Equal(expected, actual);
    }
}