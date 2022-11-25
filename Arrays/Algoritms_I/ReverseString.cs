namespace Arrays;

public class ReverseString
{
    public char[] Do(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }
        return s;
    }
}