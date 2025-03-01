namespace CSharp.Easy.SuperEasyProblems;

public class FindIfDigitGameCanBeWon
{
    public bool CanAliceWin(int[] nums) 
    {
        int singleDigitSum = 0;
        int doubleDigitSum = 0;

        foreach (int num in nums)
        {
            if(num < 10)
                singleDigitSum += num;
            else
                doubleDigitSum += num;
        }

        return singleDigitSum != doubleDigitSum;
    }
}
