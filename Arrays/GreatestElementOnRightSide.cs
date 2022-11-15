namespace Arrays;

public class GreatestElementOnRightSide
{
    public int[] Do(int[] arr)
    {
        int max = arr[^1];
        int i = arr.Length - 1;
        int counter = arr.Length;

        if (i == 0)
        {
            arr[0] = -1;
            return arr;
        }
        
        while (counter != 0)
        {
            if (arr[i] > max)
            {
                (max, arr[i]) = (arr[i], max);
            }
            else
            {
                arr[i] = max;
            }
            i--;
            counter--;
        }

        arr[^1] = -1;
        
        return arr;
    }
    
    //Best algo:
    /* public int[] ReplaceElements(int[] arr) {
	var max = -1;
	for (var i = arr.Length - 1; i >= 0; i--) {
		var tmp = arr[i];
		arr[i] = max;
		if (tmp > max) {
			max = tmp;
		}
	}
	return arr;
}*/
}