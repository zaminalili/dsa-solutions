namespace CSharp.Easy.Maths;

public class SelfDividingNumbersSolution
{
    public IList<int> SelfDividingNumbers(int left, int right) 
    {
        var numbers = new List<int>();

        for (int i = left; i <= right; i++)
        {
            if(IsSelfDividing(i))
                numbers.Add(i);
        }

        return numbers;
    }

    private bool IsSelfDividing(int number) 
    {
        int tempNum = number;
        while(tempNum > 0) 
        {
            int digit = tempNum % 10;
            if(digit == 0 || number % digit != 0)
                return false;
            tempNum /= 10;
        }

        return true;
    }
}
