namespace CSharp.Easy.SuperEasyProblems;

public class CountTheDigitsThatDivideANumber
{
    public int CountDigits(int num) 
    {
        int count = 0;
        int power = 1;
        double prev = 0;

        for (int i = 1; i <= num.ToString().Length; i++)
        {
            double modValue = Math.Pow(10, power);
            double mod = num % modValue;
            double digit = (mod - prev) / (modValue/10); 

            if(num % digit == 0)
                count++;

            prev = mod;
            power++;
        }

        return count;   
    }
}
