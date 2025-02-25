namespace CSharp.Easy.SuperEasyProblems;

public class SquaresOfASortedArray
{
    public int[] SortedSquares(int[] nums) 
    {
        int[] result = new int[nums.Length]; 
        int i = 0;
        int j = nums.Length-1;
        int k = j;

        while (k >= 0) 
        {

            if(Math.Abs(nums[i]) > Math.Abs(nums[j])) 
            {   
                result[k] = nums[i]*nums[i];
                i++;
            }
            else 
            {
                result[k] = nums[j]*nums[j];
                j--;
            }

            k--;
        }
        
        return result;
    }
}
