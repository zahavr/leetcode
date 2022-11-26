using System.Reflection;
using Xunit;

namespace Arrays.Tests;

public class ReverseStringTests
{
    [Theory]
    [InlineData(new[] {'h','e','l','l','o'}, new[] {'o','l','l','e','h'})]
    [InlineData(new[] {'H','a','n','n','a','h'}, new[] {'h','a','n','n','a','H'})]
    public void ReverseString_Do_Success(char[] s, char[] expected)
    {
        var sut = new ReverseString();
        char[] actual = sut.Do(s);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new[] {'h','e','l','l','o'}, new[] {'o','l','l','e','h'})]
    [InlineData(new[] {'H','a','n','n','a','h'}, new[] {'h','a','n','n','a','H'})]
    public void ReverseString_Recursive_Success(char[] s, char[] expected)
    {
        var sut = new ReverseString();
        char[] actual = sut.Recursive(s);
        
        Assert.Equal(expected, actual);
    }
}