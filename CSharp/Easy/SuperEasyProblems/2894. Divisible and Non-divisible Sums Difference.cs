namespace CSharp.Easy.SuperEasyProblems;

public class DivisibleAndNonDivisibleSumsDifference
{
    public int DifferenceOfSums(int n, int m) 
    {
        int k = n/m;
        int sumAll = n * (n+1) / 2;
        int sumNonDivisible = k * (2*m + m*(k-1)) / 2;

        return sumAll - 2*sumNonDivisible;
    }
}
