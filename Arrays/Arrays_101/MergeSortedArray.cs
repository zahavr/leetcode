namespace Arrays;

public class MergeSortedArray
{
    // M - representing the number of elements in nums1
    // N - representing the number of elements in nums2
    // Nums1 has a length m + n
    // 
    public int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0 || nums1.Length == 0)
        {
            Array.Copy(nums2, nums1, n);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m] = nums2[i];
                m++;
            }
            Array.Sort(nums1);
        }
        
        return nums1;
    }
}