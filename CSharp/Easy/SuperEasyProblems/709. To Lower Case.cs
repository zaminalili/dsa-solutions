using System.Text;

namespace CSharp.Easy.SuperEasyProblems;

public class ToLowerCaseSolution
{
    public string ToLowerCase(string s) 
    {
        string lowerString = "";

        foreach (char c in s)
        {
            char lowerChar = 65 > c || c > 90 ? c : (char)(c + 32);
            lowerString += lowerChar;
        }

        return lowerString;
    }
}
