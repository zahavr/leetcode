using System.Text;

namespace Arrays;

public class ReverseWordsInAStringIII
{
    public string Do(string s)
    {
        StringBuilder sb = new StringBuilder();
        var arr = s.Split(' ');
        

        foreach (string s1 in arr)
        {
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                sb.Append(s1[i]);
            }

            sb.Append(' ');
        }

        return sb.ToString().TrimEnd();
    }
}