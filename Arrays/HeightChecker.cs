namespace Arrays;

public class HeightChecker
{
    public int Do(int[] heights)
    {
        int studentNotInPlaceCounter = 0;
        var oldHeights = new int[heights.Length];
        Array.Copy(heights, oldHeights, heights.Length);
        Array.Sort(heights);
        
        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != oldHeights[i])
            {
                studentNotInPlaceCounter++;
            }
        }
        
        return studentNotInPlaceCounter;
    }
}