using Xunit;

namespace Arrays.Tests;

public class CheckIfNandItsDoubleExistTests
{
    [Theory]
    [InlineData(true, new int[] { 10, 2, 5, 3 })]
    [InlineData(false, new int[] { 3, 1, 7, 11 })]
    [InlineData(false, new int[] { -2,0,10,-19,4,6,-8 })]
    public void CheckIfNandItsDoubleExist(bool expected, int[] arr)
    {
        var sut = new CheckIfNandItsDoubleExist();
        var actual = sut.Do(arr);
        
        Assert.Equal(expected, actual);
    }
}