namespace CSharp.Easy.SuperEasyProblems;

public static class CheckIfTheSentenceIsPangram
{
    public static bool CheckIfPangram(string sentence) 
    {
        string foundChars = "";

        foreach (char c in sentence)
        {
            if(!foundChars.Contains(c))
                foundChars += c;
        }

        return foundChars.Length == 26;
    }
}
