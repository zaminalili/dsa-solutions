namespace CSharp;

public class MyQueue<T>
{
    // FIFO
    // 0, 2, 3, 4, 5
    // len = 5 count = 4
    T[] items;

    const int defaultCapacity = 10;

    int front = 0; 
    int back = -1; 
    int count = 0;

    public MyQueue(int initialCapacity = defaultCapacity)
    {
        items = new T[initialCapacity];
    }

    public void Enqueue(T value) 
    {
        count++;
        back++;
        items[back] = value;
        Resize();
    }

    public T Dequeue() 
    {
        if(count == 0)
            throw new InvalidOperationException("Queue empty");
        
        T value = items[front];
        items[front] = default!;
        front++;
        count--;

        var newItems = new T[count];


        Array.Copy(items, front, newItems, 0, newItems.Length);

        items = newItems;
        front = 0;
        back--;

        Resize();

        return value;
    }

    public int Count() => count;

    private void Resize() 
    {
        if(back >= items.Length-1) 
        {
            Array.Resize(ref items, count*2);
        }
        else if(back < items.Length/2)
        {
            var newItems = new T[items.Length/2];

            Array.Copy(items, items.Length-count, newItems, 0, newItems.Length);
        }
    }

    public void Write()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}
