namespace CSharp.Easy.SuperEasyProblems;

public static class AddDigitsSolution
{
    public static int AddDigits(int num) 
    {
        return num == 0 ? 0 
        : (num % 9 == 0 ? 9 : num % 9);
    }
}
