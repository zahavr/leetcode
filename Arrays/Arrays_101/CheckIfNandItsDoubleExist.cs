namespace Arrays;

public class CheckIfNandItsDoubleExist
{
    public bool Do(int[] arr)
    {
        if (arr.Length == 0)
        {
            return false;
        }
        
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == 2 * arr[j] && i!= j)
                    return true;
            }
        }

        return false;
    }
}