namespace CSharp.Easy.SuperEasyProblems;

public class DifferenceBetweenElementSumAndDigitSumOfAnArray
{
    public int DifferenceOfSum(int[] nums) 
    {
        int difference = 0;

        foreach (int num in nums)
        {
            difference += Math.Abs(num - (num % 10 + (num / 10 % 10)+ (num / 100 % 10) + (num / 1000)));
        }

        return difference;    
    }
}
