namespace CSharp.Easy.SlidingWindow;

public static class MaximumAverageSubarray
{
    public static double FindMaxAverage(int[] nums, int k) 
    {
        var sum = nums.Take(k).Sum();
        double average, maxAverage = sum / (double)k;

        for (int i = k; i < nums.Length; i++)
        {
            sum -= nums[i-k] - nums[i];
            average = sum / (double)k;

            if(average > maxAverage)
                maxAverage = average;
        }

        return maxAverage;    
    }
}
