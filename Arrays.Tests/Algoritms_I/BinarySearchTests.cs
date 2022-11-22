using Xunit;

namespace Arrays.Tests;

public class BinarySearchTests
{
    [Theory]
    [InlineData(new[] {-1,0,3,5,9,12}, 9, 4)]
    [InlineData(new[] {-1,0,3,5,9,12}, 2, -1)]
    public void BinarySearch_Do_Success(int[] nums, int target, int expected)
    {
        var sut = new BinarySearch();
        var actual = sut.LinearSearch(nums, target);
        
        Assert.Equal(expected, actual);
    }
}