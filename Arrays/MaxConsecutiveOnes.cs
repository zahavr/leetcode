namespace Arrays;

public class MaxConsecutiveOnes
{
    public int BrutForce(int[] nums)
    {
        var maxSequence = 0;

        for (int left = 0; left < nums.Length; left++)
        {
            int zeroNums = 0;

            for (int right = left; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    zeroNums++;
                }

                if (zeroNums <= 1)
                {
                    maxSequence = Math.Max(maxSequence, right - left + 1);
                }
            }
            
        }
        
        return maxSequence;
    }

    public int SlidingWindow(int[] nums)
    {
        var maxSequence = 0;
        var left = 0;
        var right = 0;
        var zeroNums = 0;

        while (right < nums.Length)
        {
            if (nums[right] == 0)
            {
                zeroNums++;
            }

            while (zeroNums == 2)
            {
                if (nums[left] == 0)
                {
                    zeroNums--;
                }

                left++;
            }

            maxSequence = Math.Max(maxSequence, right - left + 1);
            right++;
        }

        Array.BinarySearch(nums, left);
        return maxSequence;
    }
}