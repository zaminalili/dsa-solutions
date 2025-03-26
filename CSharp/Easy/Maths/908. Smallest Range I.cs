namespace CSharp.Easy.Maths;

public class SmallestRangeISolution
{
    public int SmallestRangeI(int[] nums, int k) 
    {
        int min = int.MaxValue, max = int.MinValue;

        foreach (int num in nums)
        {
            if(num < min)
                min = num;
            if(num > max)
                max = num;
        }

        return Math.Max(0, (max-k) - (min+k));  
    }
}
