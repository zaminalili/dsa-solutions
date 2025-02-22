namespace CSharp.Easy.SuperEasyProblems;

public static class MaximumNumberOfWordsFoundInSentences
{
    public static int MostWordsFound(string[] sentences) 
    {
        int maxWord = 0;

        foreach (string word in sentences)
        {
            int wordCount = word.Split(' ').Length;
            if (wordCount > maxWord)
                maxWord = wordCount;
        }

        return maxWord;    
    }   
}
