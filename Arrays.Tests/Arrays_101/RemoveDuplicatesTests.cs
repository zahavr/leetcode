using Xunit;

namespace Arrays.Tests;

public class RemoveDuplicatesTests
{
    [Theory]
    [InlineData(5, new int[] {0,0,1,1,1,2,2,3,3,4})]
    [InlineData(2, new int[] {1,1,2})]
    public void RemoveDuplicates(int expected, int[] arr)
    {
        RemoveDuplicates removeDuplicates = new RemoveDuplicates();
        int actual = removeDuplicates.Do(arr);
        
        Assert.Equal(expected, actual);
    }
}