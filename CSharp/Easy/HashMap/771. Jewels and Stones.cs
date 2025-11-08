public class Solution771 
{
    public int NumJewelsInStones(string jewels, string stones) 
    {
        var myJewels = new Dictionary<char, int>();

        foreach (var stone in stones)
        {
            if(jewels.Contains(stone))
            {
                if(myJewels.TryGetValue(stone, out int count))
                {
                    myJewels[stone] = count+1;
                }
                else 
                {
                    myJewels[stone] = 1;
                }
            }
        }

        return myJewels.Values.Sum();
    }
}