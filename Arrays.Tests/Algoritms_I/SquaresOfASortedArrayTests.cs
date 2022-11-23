using Xunit;

namespace Arrays.Tests;

public class SquaresOfASortedArrayTests
{
    [Theory]
    [InlineData(new[] {-4,-1,0,3,10}, new[] {0,1,9,16,100})]
    [InlineData(new[] {-7,-3,2,3,11}, new[] {4,9,9,49,121})]
    public void SquaresOfASortedArray_Do_Success(int[] nums, int[] expected)
    {
        var sut = new SquaresOfASortedArray();
        int[] actual = sut.Do(nums);
        
        Assert.Equal(expected, actual);
    }
}