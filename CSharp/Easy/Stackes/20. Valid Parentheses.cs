namespace CSharp.Easy.Stackes;

public class ValidParentheses
{
    public bool IsValid(string s) 
    {
        var couples = new Dictionary<char, char>()
        { 
            {')', '('}, 
            {']', '['},
            {'}', '{'} 
        };       
        var stack = new Stack<char>();

        foreach (char bracket in s)
        {
            if (couples.ContainsValue(bracket)) 
                stack.Push(bracket);
            else if(couples.ContainsKey(bracket) 
                    && (stack.Count == 0 || couples[bracket] != stack.Pop())) 
                return false;
        }

        return stack.Count == 0;
    }
}
