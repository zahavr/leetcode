using System.Security.Cryptography;
using Xunit;

namespace Arrays.Tests;

public class SearchInsertTests
{
    [Theory]
    [InlineData(new[] {1,3,5,6}, 5, 2)]
    [InlineData(new[] {1,3,5,6}, 2, 1)]
    [InlineData(new[] {1,3,5,6}, 7, 4)]
    public void SearchInsert_Do_Success(int[] nums, int target, int expected)
    {
        var sut = new SearchInsert();
        int actual = sut.Do(nums, target);
        
        Assert.Equal(expected, actual);
    }
}