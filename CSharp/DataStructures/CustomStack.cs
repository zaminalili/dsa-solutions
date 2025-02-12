namespace CSharp;

public class CustomStack<T>
{
    // LIFO

    T[] items;
    const int capacity = 10;
    int top = -1; 


    public CustomStack(int capacity = capacity) 
    {
        items = new T[capacity];
    }

    public void Push(T value) 
    {
        top++;
        items[top] = value;
    }

    public T Pop() 
    {
        T value = items[top];
        items[top] = default!;
        top--;
        
        return value;
    }
}
