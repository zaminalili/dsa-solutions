namespace CSharp.Easy.Maths;

public class ExcelSheetColumnTitle
{
    public string ConvertToTitle(int columnNumber) 
    {
        string result = "";

        while(columnNumber > 26) 
        {
            var remainder = columnNumber % 26;
            columnNumber /= 26;
            if(remainder == 0) 
            {
                remainder = 26;
                columnNumber--;
            }

            result = (char)(remainder+64) + result;
        }

        return (char)(columnNumber+64) + result;
    }
}
