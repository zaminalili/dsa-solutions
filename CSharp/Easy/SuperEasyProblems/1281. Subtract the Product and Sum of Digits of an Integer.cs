namespace CSharp.Easy.SuperEasyProblems;

public class SubtractTheProductAndSumOfDigitsOfAnInteger
{
    public int SubtractProductAndSum(int n) 
    {
        int product = 1;
        int sum = 0;

        while (n > 0) 
        {
            int digit = n % 10;
            n /= 10;
            product *= digit;
            sum += digit;
        }

        return product - sum;    
    }
}
