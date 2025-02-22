namespace CSharp.Easy.SuperEasyProblems;

public class CountTheDigitsThatDivideANumber
{
    public int CountDigits(int num) 
    {
        int count = 0;
        int part = num;

        while (part > 0) 
        {
            if(num % (part % 10) == 0) 
                count++; 
            part /= 10;
        }

        return count;   
    }
}
