namespace CSharp;

public class CustomQueue<T>
{
    // FIFO

    T[] items;

    const int capacity = 10;

    int head = 0; 
    int tail = -1; 
    int count = 0;

    public CustomQueue(int capacity = capacity)
    {
        items = new T[capacity];
    }

    public void Enqueue(T value) 
    {
        count++;
        tail++;
        items[tail] = value;
        Resize();
    }

    public T Dequeue() 
    {
        T value = items[head];
        items[head] = default!;
        head++;
        count--;

        return value;
    }

    public int Count => count;

    private void Resize() 
    {
        if(tail > items.Length) 
        {
            Array.Resize(ref items, count*2);
            head = 0;
            tail = -1;
        }
        else 
        {
            var newItems = new T[items.Length/2];
        }
    }
}
