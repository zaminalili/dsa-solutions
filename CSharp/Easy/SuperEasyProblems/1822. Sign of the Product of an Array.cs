namespace CSharp.Easy.SuperEasyProblems;

public class SignOfTheProductOfAnArray
{
    public int ArraySign(int[] nums) 
    {
        int sign = 1;

       foreach (int num in nums)
       {
            if(num == 0)
                return 0;
            if(num < 0)
                sign = -sign;
       }

        return sign;
    }
}
