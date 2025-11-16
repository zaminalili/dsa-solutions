namespace CSharp.Sorting;

public static class CountingSort 
{
    public static int[] SortAsc(int[] arr) 
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > max)
                max = arr[i];
        }

        var countingArr = new int[max+1];

        for (int i = 0; i < arr.Length; i++)
        {
            countingArr[arr[i]]++; 
        }


        int k = 0;
        for (int j = 0; j < countingArr.Length; j++)
        {
            while(countingArr[j] > 0)
            {
                arr[k++] = j;
                countingArr[j]--;
            }
        }


        return arr;
    }
}