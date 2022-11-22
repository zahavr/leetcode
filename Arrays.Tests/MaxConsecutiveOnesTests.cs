using Xunit;

namespace Arrays.Tests;

public class MaxConsecutiveOnesTests
{
    [Theory]
    [InlineData(new[] {1,0,1,1,0}, 4)]
    [InlineData(new[] {1,0,1,1,0,1}, 4)]
    public void MaxConsecutiveOnes_BrutForce_Success(int[] nums, int expected)
    {
        var sut = new MaxConsecutiveOnes();
        var actual = sut.BrutForce(nums);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new[] {1,0,1,1,0}, 4)]
    [InlineData(new[] {1,0,1,1,0,1}, 4)]
    public void MaxConsecutiveOnes_SlidingWindow_Success(int[] nums, int expected)
    {
        var sut = new MaxConsecutiveOnes();
        var actual = sut.SlidingWindow(nums);
        
        Assert.Equal(expected, actual);
    }
}