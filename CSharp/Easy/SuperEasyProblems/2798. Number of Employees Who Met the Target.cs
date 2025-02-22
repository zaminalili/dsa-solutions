namespace CSharp.Easy.SuperEasyProblems;

public class NumberOfEmployeesWhoMetTheTarget
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) 
    {
        int metTheTargetCount = 0;

        foreach (int hour in hours)
        {
            if(hour >= target)
                metTheTargetCount++;
        }

        return metTheTargetCount;    
    }
}
