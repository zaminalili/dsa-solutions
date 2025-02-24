namespace CSharp.Easy.SuperEasyProblems;

public class FindWordsContainingCharacter
{
    public IList<int> FindWordsContaining(string[] words, char x) 
    {
        IList<int> result = [];

        for (int i = 0; i < words.Length; i++)
        {
            if(Contains(words[i], x))
                result.Add(i);
        }

        return result;    
    }

    private bool Contains(string s, char x) 
    {
        foreach (char c in s)
        {
            if(c == x)
                return true;
        }
        return false;
    }
}
