namespace CSharp.Easy.SuperEasyProblems;

public class BaseballGame
{
    public int CalPoints(string[] operations) 
    {
        List<int> records = [];

        foreach (var opr in operations)
        {
            switch (opr)
            {
                case "C":
                    records.RemoveAt(records.Count - 1);
                    break;
                case "D":
                    records.Add(records[^1] *2);
                    break;
                case "+":
                    records.Add(records[^1] +records[^2]);
                    break;
                default:
                    records.Add(Int32.Parse(opr));
                    break;
            }
        }

        return records.Sum();    
    }
}
