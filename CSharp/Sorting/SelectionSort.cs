namespace CSharp.Sorting;

public static class SelectionSort
{
    public static int[] SortAsc(int[] arr) 
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if(arr[i] > arr[j]) 
                {
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                    continue;
                }
            }
        }

        return arr;
    }

    public static int[] SortDesc(int[] arr) 
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if(arr[i] < arr[j]) 
                {
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                    continue;
                }
            }
        }

        return arr;
    }
}
