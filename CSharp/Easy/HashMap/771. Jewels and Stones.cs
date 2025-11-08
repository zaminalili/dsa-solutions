public class Solution771 
{
    public int NumJewelsInStones(string jewels, string stones) 
    {
        var result = 0;

        foreach (var stone in stones)
        {
            if(jewels.Contains(stone))
                result++;
        }

        return result;
    }
}