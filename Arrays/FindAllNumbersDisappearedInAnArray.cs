namespace Arrays;

public class FindAllNumbersDisappearedInAnArray
{
    public IList<int> Do(int[] nums)
    {
        var res=new HashSet<int>(Enumerable.Range(1,nums.Length));
        foreach (var item in nums)
            res.Remove(item);
        return res.ToArray();
    }
}