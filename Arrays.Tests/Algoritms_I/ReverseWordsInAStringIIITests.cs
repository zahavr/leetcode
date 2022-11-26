using Xunit;

namespace Arrays.Tests;

public class ReverseWordsInAStringIIITests
{
    [Theory]
    [InlineData("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [InlineData("God Ding", "doG gniD")]
    public void ReverseWordsInAStringIIITests_Do_Success(string s, string expected)
    {
        var sut = new ReverseWordsInAStringIII();
        var actual = sut.Do(s);
        
        Assert.Equal(expected, actual);
    }
}