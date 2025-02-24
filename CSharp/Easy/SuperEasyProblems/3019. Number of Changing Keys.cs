namespace CSharp.Easy.SuperEasyProblems;

public class NumberOfChangingKeys
{
    public int CountKeyChanges(string s) 
    {
        int count = 0;

        for (int i = 0; i < s.Length-1; i++)
        {
            if(!(s[i] == s[i+1] || s[i]+32 == s[i+1] || s[i]-32 == s[i+1]))
                count++;
        }

        return count;
    }
}
