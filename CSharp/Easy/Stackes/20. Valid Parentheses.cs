namespace CSharp.Easy.Stackes;

public class ValidParentheses
{
    public bool IsValid(string s) 
    {
        //const string openBrackets = "([{";
        var stack = new Stack<char>();

        foreach (char bracket in s)
        {
            if(stack.Count != 0 && IsPair(stack.Peek(), bracket)) 
            {
                stack.Pop();
                continue;
            }

            stack.Push(bracket);
        }

        return stack.Count == 0;
    }

    public bool IsPair(char open, char close) 
    {
        return open == '(' && close == ')' 
        || open == '[' && close == ']'
        || open == '{' && close == '}';
    }
}
