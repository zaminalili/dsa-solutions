namespace CSharp.Easy.SlidingWindow;

public static class MaximumAverageSubarray
{
    public static double FindMaxAverage(int[] nums, int k) 
    {
        int sum = Sum(nums, 0, k);
        //double average, maxAverage = sum / (double)k;
        int maxSum = sum;
        for (int i = k; i < nums.Length; i++)
        {
            sum -= nums[i-k] - nums[i];
            //average = sum / (double)k;
            if(sum > maxSum)
                maxSum = sum;
        }

        return maxSum / (double)k;    
    }
    
    private static int Sum(int[]nums, int firstIndex, int lastIndex) 
    {
        int sum = 0;
        for (int i = firstIndex; i < lastIndex; i++)
        {
            sum += nums[i];
        }

        return sum;
    }
}
