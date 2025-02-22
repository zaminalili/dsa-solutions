using CSharp.Sorting;

namespace CSharp.Easy.SuperEasyProblems;

public static class MinimumNumberGame
{
    public static int[] NumberGame(int[] nums) 
    {
        nums = SelectionSort.SortAsc(nums);

        int i = 0;
        int j = 1;

        while (j < nums.Length) 
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
            i += 2;
            j += 2;
        }

        return nums;   
    }
}
