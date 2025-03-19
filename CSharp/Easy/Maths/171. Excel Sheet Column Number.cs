namespace CSharp.Easy.Maths;

public class ExcelSheetColumnNumber
{
    public int TitleToNumber(string columnTitle) 
    {
        int total = 0;

        foreach (char c in columnTitle)
            total = total * 26 + (c - 'A' + 1);

        return total;
    }
}
