using System.Reflection;
using System.Runtime.Intrinsics.X86;
using Xunit;

namespace Arrays.Tests;

public class TwoSumsTests
{
    [Theory]
    [InlineData(new[] { 2,7,11,15 }, 9, new[] {1, 2})]
    [InlineData(new[] { 2,3,4 }, 6, new[] {1, 3})]
    [InlineData(new[] { -1, 0 }, -1, new[] {1, 2})]
    public void TwoSums_Do_Success(int[] nums, int target, int[] expected)
    {
        var sut = new TwoSums();
        var actual = sut.Do(nums, target);
        
        Assert.Equal(expected, actual);
    }
}