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
    
    public char[] Recursive(char[] s)
    {
         Helper(0, s.Length - 1, s);

         return s;
    }

    private void Helper(int first, int last, char[] str)
    {
        if (first >= last)
        {
            return;
        }
        (str[first], str[last]) = (str[last], str[first]);
        Helper(first + 1, last - 1, str);
    }
}