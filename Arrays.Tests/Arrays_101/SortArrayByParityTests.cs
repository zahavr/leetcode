using Xunit;

namespace Arrays.Tests;

public class SortArrayByParityTests
{
    [Theory]
    [InlineData(new int[] { 3, 1, 2, 4 }, new int[] { 4,2,1,3 })]
    [InlineData(new int[] { 1,0,3 }, new int[] { 0, 3, 1 })]
    public void SortArrayByParity_Do_Success(int[] nums, int[] expected)
    {
        var sut = new SortArrayByParity();
        var actual = sut.Do(nums);
        
        Assert.Equal(expected, actual);
    }
}