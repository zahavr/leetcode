using Xunit;

namespace Arrays.Tests;

public class RemoveElementTests
{
    [Theory]
    [InlineData(new int[] { 3,2,2,3 }, 3 , 2)]
    [InlineData(new int[] { 0,1,2,2,3,0,4,2 }, 2 , 5)]
    public void RemoveElement(int[] arr, int value, int expected)
    {
        RemoveElement sut = new RemoveElement();

        int actual = sut.Do(arr, value);
        
        Assert.Equal(expected, actual);
    }
    
}