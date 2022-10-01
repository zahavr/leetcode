namespace Arrays;

public class DuplicateZeros
{
    public int[] Run(int[] arr)
    {
        int[] newArray = new int[arr.Length];
        int insertedPosition = 0;

        for (int i = 0; insertedPosition < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                newArray[insertedPosition] = 0;
                insertedPosition += 2;
            }
            else
            {
                newArray[insertedPosition] = arr[i];
                insertedPosition++;
            }
        }

        Array.Copy(newArray, arr, arr.Length);

        return arr;
    }
}