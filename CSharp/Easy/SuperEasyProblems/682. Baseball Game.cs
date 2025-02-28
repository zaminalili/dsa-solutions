namespace CSharp.Easy.SuperEasyProblems;

public class BaseballGame
{
    public int CalPoints(string[] operations) 
    {
        Stack<int> records = new();
        int sum = 0;

        foreach (var opr in operations)
        {
            switch (opr)
            {
                case "C":
                    sum -= records.Pop();
                    break;
                case "D":
                    sum += records.Peek() * 2;
                    records.Push(records.Peek() * 2);
                    break;
                case "+":
                    int top = records.Pop();
                    int newTop = top + records.Peek();
                    
                    sum += newTop;
                    records.Push(top);
                    records.Push(newTop);
                    break;
                default:
                    sum += Int32.Parse(opr);
                    records.Push(Int32.Parse(opr));
                    break;
            }
        }

        return sum;    
    }
}
