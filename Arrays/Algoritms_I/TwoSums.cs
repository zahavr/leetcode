namespace Arrays;

public class TwoSums
{
    public int[] Do(int[] numbers, int target) {
        int[] result = {int.MinValue, int.MinValue};
        int left = 0;
        int right = numbers.Length - 1;

        while(left < right)
        {
            if(numbers[left] + numbers[right] == target)
            {
                result[0] = left + 1;
                result[1] = right + 1;
                return result;
            }

            if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        
        return result;
    }
}