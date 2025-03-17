namespace CSharp.Easy.Maths;

public class ExcelSheetColumnNumber
{
    public int TitleToNumber(string columnTitle) 
    {
        int total = 0;
        int count = columnTitle.Length - 1;

        for (int i = count; i >= 0 ; i--)
        {
            int number = columnTitle[i]-64;
            int pow = (int)Math.Pow(26, count - i);
            total += number * pow;
        }

        return total;
    }
}
