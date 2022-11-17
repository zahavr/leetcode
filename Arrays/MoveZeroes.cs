namespace Arrays;

public class MoveZeroes
{
    public int[] Do(int[] nums)
    {
        var newArr = new int[nums.Length];
        var positionInNewArray = 0;

        for (int readIndex = 0; readIndex < nums.Length; readIndex++)
        {
            if (nums[readIndex] != 0)
            {
                newArr[positionInNewArray] = nums[readIndex];
                positionInNewArray++;
            }
        }
        Array.Copy(newArr, nums, newArr.Length);
        return newArr;
    }
}