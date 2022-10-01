using Xunit;

namespace Arrays.Tests;

public class DuplicateZerosTests
{
    [Theory]
    [InlineData(new int[] {1,0,2,3,0,4,5,0}, new int[] {1,0,0,2,3,0,0,4})]
    [InlineData(new int[] {1,2,3}, new int[] {1,2,3})]
    [InlineData(new int[] {0,0,1}, new int[] {0,0,0})]
    public void DuplicateZeros(int[] actual, int[] expected) 
    {
        var sut = new DuplicateZeros();
        actual = sut.Run(actual);
        
        Assert.Equal(expected, actual);
    } 
}