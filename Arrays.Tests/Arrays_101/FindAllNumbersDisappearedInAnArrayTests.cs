using System.Collections.Generic;
using Xunit;

namespace Arrays.Tests;

public class FindAllNumbersDisappearedInAnArrayTests
{
    [Theory]
    [InlineData(new[] { 5,6 }, new[] { 4,3,2,7,8,2,3,1 })]
    [InlineData(new[] { 2 }, new[] { 1,1 })]
    public void FindAllNumbersDisappearedInAnArray_Do_Success(IList<int> expected, int[] nums)
    {
        var sut = new FindAllNumbersDisappearedInAnArray();
        var actual = sut.Do(nums);
        
        Assert.Equal(expected, actual);
    }
}