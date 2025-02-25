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
            int powI = (int)Math.Pow(nums[i], 2);
            int powJ = (int)Math.Pow(nums[j], 2);

            if(powI > powJ) 
            {   
                result[k] = powI;
                i++;
            }
            else 
            {
                result[k] = powJ;
                j--;
            }

            k--;
        }
        
        return result;
    }
}
