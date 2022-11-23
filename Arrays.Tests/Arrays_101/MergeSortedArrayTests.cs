using Xunit;

namespace Arrays.Tests;

public class MergeSortedArrayTests
{
    [Theory]
    [InlineData(new[] {1,2,3,0,0,0}, 3, new[]{2,5,6}, 3, new[] {1,2,2,3,5,6})]
    [InlineData(new[] {1}, 1, new int[]{}, 0, new[] {1})]
    [InlineData(new int[] {0}, 0, new []{1}, 1, new[] {1})]
    public void MergeSortedArray(int[] nums1, int m, int[] nums2, int n, int[] expected) 
    {
        var sut = new MergeSortedArray();
        var actual = sut.Merge(nums1, m, nums2, n);
        
        Assert.Equal(expected, actual);
    } 
}