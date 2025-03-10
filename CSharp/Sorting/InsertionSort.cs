namespace CSharp.Sorting;

public static class InsertionSort
{
    public static int[] SortAsc(int[] arr) 
    {
        for (int i = 1; i < arr.Length; i++)
        {
           int j = i-1;
           int k = i;
           while (j >= 0)
           {
                if(arr[j] > arr[k])
                {
                    (arr[j], arr[k]) = (arr[k], arr[j]);
                }
                j--;
                k--;
           }     
        }        

        return arr;
    }    
}
