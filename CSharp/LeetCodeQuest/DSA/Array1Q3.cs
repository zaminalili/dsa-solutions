public class SolutionArray1Q2 {
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int count = 0, max = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                if(++count > max)
                    max = count;
            }  
            else
            {
                count = 0;
            }
        }

        return max;
    }
}