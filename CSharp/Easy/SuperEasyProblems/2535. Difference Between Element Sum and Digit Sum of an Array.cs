namespace CSharp.Easy.SuperEasyProblems;

public class DifferenceBetweenElementSumAndDigitSumOfAnArray
{
    public int DifferenceOfSum(int[] nums) 
    {
        int difference = 0;

        foreach (int num in nums)
        {
            if(num >= 10) 
                difference += Math.Abs(num - SumDigit(num));
        }

        return difference;    
    }

    private static int SumDigit(int num) 
    {
        int digitSum = 0;

        while(num > 0) 
        {
            digitSum += num % 10;
            num /= 10; 
        }

        return digitSum;
    }
}
