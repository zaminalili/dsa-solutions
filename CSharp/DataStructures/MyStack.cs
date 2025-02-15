namespace CSharp;

public class MyStack<T>
{
    // LIFO
    // 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 
    //   top     count
    T[] items;
    const int defaultCapacity = 10;
    int top = -1; 


    public MyStack(int initialCapacity = defaultCapacity) 
    {
        items = new T[initialCapacity];
    }

    public void Push(T value) 
    {
        Resize();
        top++;
        items[top] = value;

    }

    public T Pop() 
    {
        CheckItems();

        Resize();
        T value = items[top];
        items[top] = default!;
        top--;

        return value;
    }

    public T Peek()
    {
        CheckItems();

        return items[top];
    }

    public int Count() => top+1;

    public void Write() 
    {
        for (int i = 0; i <= top; i++)
        {
            Console.WriteLine(items[i]);
        }
    }

    private void CheckItems()
    {
        if (top < 0)
            throw new InvalidOperationException("Stack is empty");
    }

    private void Resize() 
    {
        if(top >= items.Length-1) 
        {
            Array.Resize(ref items, items.Length*2);
        }
        else if(top < items.Length/2) 
        {
            var newArr = new T[items.Length/2];

            Array.Copy(items, 0, newArr, 0, newArr.Length);
            items = newArr;
        }
    }


}
