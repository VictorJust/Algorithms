namespace Searching;

public class LinearSearch
{
    public static int Search(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return i;
            }
        }

        return -1;
    }
}