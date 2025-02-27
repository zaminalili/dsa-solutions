namespace CSharp.Easy.SuperEasyProblems;

public class ThreeConsecutiveOddsSolution
{
    public bool ThreeConsecutiveOdds(int[] arr) 
    {
        int consecutiveCount = 0;

        foreach (int num in arr)
        {
            if(num % 2 == 0)
                consecutiveCount = 0;
            else
            {
                consecutiveCount++;
                if(consecutiveCount >= 3) return true; 
            }
        }

        return false;   
    }
}
