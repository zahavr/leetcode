using Xunit;

namespace Arrays.Tests;

public class GreatestElementOnRightSideTests
{
    [Theory]
    [InlineData(new int[] { 17,18,5,4,6,1}, new int[] { 18,6,6,6,1,-1 })]
    [InlineData(new int[] { 400 }, new int[] { -1 })]
    public void GreatestElementOnRightSide_Do_Success(int[] arr, int[] expected)
    {
        var sut = new GreatestElementOnRightSide();
        var actual = sut.Do(arr);
        
        Assert.Equal(expected, actual);
    }
}