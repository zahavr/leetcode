namespace Arrays;

public class SquaresOfASortedArray
{
    public int[] Do(int[] nums)
    {
        int arrayLength = nums.Length;
        int[] result = new int[arrayLength];
        int leftPointer = 0;
        int rightPointer = arrayLength - 1;

        for (int i = arrayLength - 1; i >= 0; i--)
        {
            int squaredNumber;
            
            if (Math.Abs(nums[leftPointer]) < Math.Abs(nums[rightPointer]))
            {
                squaredNumber = nums[rightPointer];
                rightPointer--;
            }
            else
            {
                squaredNumber = nums[leftPointer];
                leftPointer++;
            }
            
            result[i] = squaredNumber * squaredNumber;
        }

        return result;
    }
}