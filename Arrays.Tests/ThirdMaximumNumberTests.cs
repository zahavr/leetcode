using Xunit;

namespace Arrays.Tests;

public class ThirdMaximumNumberTests
{
    [Theory]
    [InlineData(new[] { 3, 2, 1 }, 1)]
    [InlineData(new[] { 1, 2 }, 2)]
    [InlineData(new[] { 2, 2, 3, 1 }, 1)]
    public void ThirdMaximumNumber_Do_Success(int[] nums, int expected)
    {
        var sut = new ThirdMaximumNumber();
        var actual = sut.Do(nums);
        
        Assert.Equal(expected, actual);
    }
}