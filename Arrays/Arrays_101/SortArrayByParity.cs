namespace Arrays;

public class SortArrayByParity
{
    public int[] Do(int[] nums)
    {
        int indexFromStart = 0, indexFromEnd = nums.Length - 1;

        while (indexFromEnd >= indexFromStart)
        {
            if (nums[indexFromStart] % 2 != 0)
            {
                (nums[indexFromEnd], nums[indexFromStart]) = (nums[indexFromStart], nums[indexFromEnd]);
                indexFromEnd--;
            }
            else
            {
                indexFromStart++;
            }
        }
        
        return nums;
    }
}