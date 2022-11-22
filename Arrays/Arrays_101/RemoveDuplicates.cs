namespace Arrays;

public class RemoveDuplicates
{
    public int Do(int[] nums)
    {
        int temp = nums[0];
        int length = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (temp < nums[i])
            {
                temp = nums[i];
                nums[length] = temp;
                length++;
            }
        }
        
        return length;
    }
}