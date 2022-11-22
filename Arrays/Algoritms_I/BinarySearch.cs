namespace Arrays;

public class BinarySearch
{
    public int Do(int[] nums, int target)
    {
        //Linear complexity O(n);
        int targetIndex = 0;

        foreach (var t in nums)
        {
            if (t == target)
            {
                break;
            }

            targetIndex++;
        }
        
        return targetIndex == nums.Length ? -1 : targetIndex;
    }
}