namespace Arrays;

public class ThirdMaximumNumber
{
    public int Do(int[] nums)
    {
        long max1 = Int64.MinValue, max2 = Int64.MinValue, max3 = Int64.MinValue;        
        
        foreach(int num in nums)
        {            
            if(num > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = num;
            }
            else if(num < max1 && num > max2)
            {
                max3 = max2;
                max2 = num;   
            }
            else if(num < max2 && num > max3)
                max3 = num;
        }
        
        return max3 == Int64.MinValue? (int)max1 : (int)max3;
    }
}