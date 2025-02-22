namespace CSharp.Easy.SuperEasyProblems;

public static class CheckIfTheSentenceIsPangram
{
    public static bool CheckIfPangram(string sentence) 
    {
        //const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        Dictionary<char, int> alphabetCounts = new() {{'a', 0},};

        for (char c = 'a'; c <= 'z'; c++)
        {
            alphabetCounts.Add(c, 0);
        }

        foreach (char c in sentence)
        {
            alphabetCounts[c] = alphabetCounts[c] + 1;
        }

        return alphabetCounts.ContainsValue(0) ? false : true;
    }
}
