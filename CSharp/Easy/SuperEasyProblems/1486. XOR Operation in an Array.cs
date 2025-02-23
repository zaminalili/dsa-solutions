namespace CSharp.Easy.SuperEasyProblems;

public class XOROperationInAnArray
{
    public int XorOperation(int n, int start) 
    {
        int bitwise = 0;

        for (int i = 0; i < n; i++)
        {
            bitwise ^= start + 2 * i;
        }

        return bitwise;    
    }
}
