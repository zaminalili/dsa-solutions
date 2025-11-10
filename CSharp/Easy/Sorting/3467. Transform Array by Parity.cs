public static class Solution3467
{
    public static int[] TransformArray(int[] nums)
    {
        int totalCount = nums.Length;
        var oddNumberFlags = new int[totalCount];
        int oddMarkerIndex = totalCount - 1;

        for (int i = 0; i < totalCount; i++)
        {
            if (nums[i] % 2 != 0)
            {
                oddNumberFlags[oddMarkerIndex] = 1;
                oddMarkerIndex--;
            }
        }

        return oddNumberFlags;
    }
}