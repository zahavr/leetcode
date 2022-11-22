using Xunit;

namespace Arrays.Tests;

public class ValidMountainArrayTests
{
    [Theory]
    [InlineData(false, new int[] { 2, 1 })]
    [InlineData(false, new int[] { 3, 5, 5 })]
    [InlineData(true, new int[] { 0, 3, 2, 1 })]
    public void ValidMountainArray(bool expected, int[] arr)
    {
        var sut = new ValidMountainArray();
        var actual = sut.Do(arr);
        
        Assert.Equal(expected, actual);
    }
    
}