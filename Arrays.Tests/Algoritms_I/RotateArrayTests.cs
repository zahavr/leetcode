using Xunit;

namespace Arrays.Tests;

public class RotateArrayTests
{
    [Theory]
    [InlineData(new[] {1,2,3,4,5,6,7}, 3, new[] {5,6,7,1,2,3,4})]
    [InlineData(new[] {-1,-100,3,99}, 2, new[] {3,99,-1,-100})]
    public void RotateArray_OnPlaceWithSort(int[] nums, int k, int[] expected)
    {
        var sut = new RotateArray();
        int[] actual = sut.OnPlace(nums, k);
        
        Assert.Equal(expected, actual);
    }
}