namespace Arrays;

public class ThirdMaximumNumber
{
    public int Do(int[] nums)
    {
        int max1 = 0;
        int max2 = 0;
        int max3 = 0;
        foreach (int n in nums) {
            if (n == max1 || n == max2 || n == max3) continue;
            if (max1 == 0 || n > max1) {
                max3 = max2;
                max2 = max1;
                max1 = n;
            } else if (max2 == 0 || n > max2) {
                max3 = max2;
                max2 = n;
            } else if (max3 == 0 || n > max3) {
                max3 = n;
            }
        }
        return max3 == 0 ? max1 : max3;
    }
}