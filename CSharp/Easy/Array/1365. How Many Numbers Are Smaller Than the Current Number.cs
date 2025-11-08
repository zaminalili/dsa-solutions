public class Solution1365 {
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        var len = nums.Length;
        var result = new int[len];

        for (int i = 0; i < len; i++)
        {
            int smallerNumsCount = 0;

            for (int j = 0; j < len; j++)
            {
                if(nums[i] > nums[j])
                    smallerNumsCount++;
            }

            result[i] = smallerNumsCount;
        }

        return result;
    }
}