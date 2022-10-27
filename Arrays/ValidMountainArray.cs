namespace Arrays;

public class ValidMountainArray
{
    public bool Do(int[] arr)
    {
        if (arr.Length < 3)
            return false;
        
        int fromStart = 0, fromEnd = arr.Length - 1;

        while (fromStart < arr.Length - 1 && arr[fromStart] < arr[fromStart + 1])
            fromStart++;

        while (fromEnd > 0 && arr[fromEnd] < arr[fromEnd - 1])
            fromEnd--;
        
        return fromStart == fromEnd && fromStart > 0 && fromEnd < arr.Length;
    }
}