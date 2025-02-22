namespace CSharp.Sorting;

public static class SelectionSort<T> where T : IComparable
{
    public static T[] SortAsc(T[] arr) 
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if(arr[i].CompareTo(arr[j]) > 0) 
                {
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                    continue;
                }
            }
        }

        return arr;
    }

    public static T[] SortDesc(T[] arr) 
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if(arr[i].CompareTo(arr[j]) < 0) 
                {
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                    continue;
                }
            }
        }

        return arr;
    }
}
