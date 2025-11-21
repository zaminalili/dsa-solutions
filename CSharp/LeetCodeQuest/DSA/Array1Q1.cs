public static class SolutionArray1Q1 {
    public static int[] GetConcatenation(int[] nums) 
    {
        int numsLen = nums.Length;
        var ans = new int[numsLen * 2];

        for (int i = 0; i < numsLen; i++)
        {
            int value = nums[i % numsLen];
            ans[i] = value;
            ans[i + numsLen] = value;
        }

        return ans;
    }
}