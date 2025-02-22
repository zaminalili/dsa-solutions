namespace CSharp.Easy.SuperEasyProblems;

public class FindFirstPalindromicStringInTheArray
{
    public string FirstPalindrome(string[] words) 
    {
        foreach (string word in words)
        {
            if(IsPalindrome(word)) 
                return word;
        }

        return "";
    }

    private static bool IsPalindrome(string word) 
    {
        int i = 0;
        int j = word.Length-1;

        while (i < j) 
        {
            if(word[i] != word[j]) 
                return false;
            i++;
            j--;
        }

        return true;
    }
}
