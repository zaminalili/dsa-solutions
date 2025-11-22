public class SolutionArray1QA1 {
    public int[] Shuffle(int[] nums, int n) 
    {
        var result = new int[2*n];

        int j = -1;
        for (int i = 0; i < n; i++)
        {
            result[++j] = nums[i];
            result[++j] = nums[i + n];
        }

        return result;
    }
}