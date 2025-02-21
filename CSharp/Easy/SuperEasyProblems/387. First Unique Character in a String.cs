namespace CSharp.Easy.SuperEasyProblems;

public static class FirstUniqueCharacterInAString
{
    public static int FirstUniqChar(string s) 
    {
        // key = character, value = count of character
        Dictionary<char, int> chars = [];

        for (int i = 0; i < s.Length; i++)
        {
            if(chars.ContainsKey(s[i])) 
                chars[s[i]] = chars[s[i]] + 1;
            else 
                chars.Add(s[i], 1);
        }

        return GetIndex(s, chars.FirstOrDefault(x => x.Value == 1).Key);   
    }

    private static int GetIndex(string s, char character) 
    {
       for (int i = 0; i < s.Length; i++)
       {
            if (s[i] == character) 
                return i;
       }

        return -1;
    }
}
