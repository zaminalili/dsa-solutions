namespace CSharp.Easy.Maths;

public class FizzBuzzSolution
{
    public IList<string> FizzBuzz(int n) 
    {
        var list = new List<string>();
        int startIndex = 1;

        if(n >= 1)
        {
            startIndex = 2;
            list.Add("1");
        }
        else if(n >= 2)
        {
            startIndex = 3;
            list.Add("2");
        }
        
        if(n < 3)
           return list;

        for (int i = startIndex; i <= n; i++)
        {
            if(i % 15 == 0)
                list.Add("FizzBuzz");
            else if(i % 3 == 0) 
                list.Add("Fizz");
            else if(i % 5 == 0)
                list.Add("Buzz");
            else
                list.Add(i.ToString());
        }

        return list;
    }
}
