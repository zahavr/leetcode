namespace Arrays;

public class BinarySearch
{
    public int LinearSearch(int[] nums, int target)
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

    public int Search(int[] nums, int target)
    {
        int start = 0;
        int last = nums.Length - 1;

        while (start <= last)
        {
            int mid = (last - start) / 2 + start;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                last = mid - 1;
            }
        }

        return -1;
    }
}