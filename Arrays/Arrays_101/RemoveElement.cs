namespace Arrays;

public class RemoveElement
{
    public int Do(int[] nums, int val)
    {
        int i = 0;
        int j = 0;

        while (i <= nums.Length - 1 && j <= nums.Length - 1)
        {
            if (nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
                i++;
            }
            else
            {
                i++;
            }
        }
        
        return j;
    }
}