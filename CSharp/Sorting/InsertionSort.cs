namespace CSharp.Sorting;

public static class InsertionSort
{
    public static int[] SortAsc(int[] arr) 
    {
        for (int i = 1; i < arr.Length; i++)
        {
           int j = i-1;
           int k = arr[i];
           while (j >= 0 && arr[j] > k)
           {
                arr[j+1] = arr[j];
                j--;
           }
           arr[j+1] = k;     
        }        

        return arr;
    }    
}
