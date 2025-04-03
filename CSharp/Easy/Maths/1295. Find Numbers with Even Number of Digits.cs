namespace CSharp.Easy.Maths;

public class Solution1295
{
    public int FindNumbers(int[] nums) 
    {
        int evenCount = 0;
        foreach (var num in nums)
        {
            if(CountDigits(num) % 2 == 0) 
                evenCount++;
            // if(num.ToString().Length % 2 == 0) 
            //     evenCount++;
        }
        return evenCount;    
    }

    int CountDigits(int num) 
    {
        int count = 0;
        while (num > 0) 
        {
            num /= 10;
            count++;
        }
        return count;
    }
}
