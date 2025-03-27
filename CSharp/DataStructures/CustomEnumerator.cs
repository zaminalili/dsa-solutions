using System.Collections;

namespace CSharp.DataStructures;

class CustomEnumerator<T> : IEnumerator<T>
{
    private T[] items;
    private int currentIndex = -1;
    private int length = 0;
    public CustomEnumerator(T[] items, int length) 
    {
        this.items = items;
        this.length = length;
    }
    
    public T Current => items[currentIndex];

    object IEnumerator.Current => Current!;

    public void Dispose()
    {
        items = null!;
    }

    public bool MoveNext()
    {
        return ++currentIndex < length;
    }

    public void Reset()
    {
        currentIndex = -1;
    }
}
