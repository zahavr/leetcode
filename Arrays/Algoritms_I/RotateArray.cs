namespace Arrays;

public class RotateArray
{
    public int[] OnPlace(int[] nums, int k)
    {
        k %= nums.Length;
        int count = 0;

        for (int i = 0; count < nums.Length; i++)
        {
            int current = i;
            int previousNumber = nums[i];
            do
            {
                int nextNumber = (current + k) % nums.Length;
                (nums[nextNumber], previousNumber) = (previousNumber, nums[nextNumber]);
                current = nextNumber;
                count++;
            } while (i != current);
        }
        
        return nums;
    }
}