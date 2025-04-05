namespace CSharp.Easy.Maths;

public class Solution1304
{
    public int[] SumZero(int n) 
    {
        var ints = new int[n];
        var i = n % 2 != 0 ? 1 : 0;

        while(i < n-1) 
        {
            ints[i] = i+1;
            ints[++i] = -i;
            i++;
        }

        return ints;
    }
}
