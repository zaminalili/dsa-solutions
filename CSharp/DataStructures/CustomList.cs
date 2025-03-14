namespace CSharp.DataStructures;

/// <summary>
/// This is dynamic array
/// </summary>
public class CustomList<T> where T : IComparable
{
    private T[] items;
    private int capacity;
    private const int defaultCapacity = 10;
    private int length = 0;

    public CustomList(int initialCapacity = defaultCapacity)
    {
        if(initialCapacity <= 0)
            throw new InvalidOperationException("Capacity cannot be zero or less");

        items = new T[initialCapacity];
        capacity = initialCapacity;
    }

    public int Length => length;

    /// <summary>
    /// Add an item to the end of the list.
    /// </summary>
    /// <param name="item">New element added to list</param>
    public void Add(T item) 
    {
        items[length] = item;
        length++;
        Resize();
    }

    /// <summary>
    /// Remove an item from the end of the list.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>  <summary>
    /// 
    /// </summary>
    public void Remove() 
    {   
        length--;
        if(length < 0)
            throw new InvalidOperationException("Cannot remove item from empty list");
        
        items[length] = default!;
        Resize();
    }

    /// <summary>
    /// Removes the item at the specified index of the list.
    /// </summary>
    /// <param name="index">Index of list</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception> <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    public void RemoveAt(int index) 
    {
        if(index < 0 || index >= length)
            throw new ArgumentOutOfRangeException("Given index does't match the length of the list.");

        for (int i = index; i < length-1; i++)
            items[i] = items[i+1];

        length--;
        items[length] = default!;
        Resize();
    }

    /// <summary>
    /// Removes the first occurrence of a specific item from the list.
    /// </summary>
    /// <param name="item">Element of list</param>
    /// <returns>False if item was not found in the list, otherwise true</returns> 
    public bool Remove(T item) 
    {
        for (int i = 0; i < length; i++)
        {
            if(items[i].CompareTo(item) == 0)
            {
                RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    private void Resize() 
    {
        if(length >= capacity) 
        {
            capacity *= 2;
            Array.Resize(ref items, capacity);
        }
        else if(length < capacity/2) 
        {
            capacity /= 2;
            Array.Resize(ref items, capacity);
        }
    }
}
