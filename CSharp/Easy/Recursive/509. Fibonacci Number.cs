namespace CSharp.Easy.Recursive;

public class FibonacciNumber
{
    public int Fib(int n) 
    {
        if (n > 1)
            return Fib(n-1) + Fib(n-2);
        
        return n;
    }
}
