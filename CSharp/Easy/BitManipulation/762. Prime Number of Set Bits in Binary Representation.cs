using System.Numerics;

namespace CSharp.Easy.BitManipulation;

public class Solution762
{
    public int CountPrimeSetBits(int left, int right) 
    {
        int result = 0;
        for (int i = left; i <= right; i++)
        {
            int setbitsCount = SetBitsCount(i);
            if(IsPrimeNumber(setbitsCount))
                result++;
        }

        return result;   
    } 

    int SetBitsCount(int num) 
    {
        int n = 0, count = 0, length = Convert.ToString(num, 2).Length;

        while(n < length) 
        {
            if((num & (1 << n)) != 0)
                count++;
            n++;
        }
        return count;
    }

    bool IsPrimeNumber (int num) 
        => new HashSet<int> { 2, 3, 5, 7, 11, 13, 17, 19 }.Contains(num);
}
