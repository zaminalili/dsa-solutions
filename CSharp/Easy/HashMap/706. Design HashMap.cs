using CSharp.DataStuctures;

namespace CSharp.Easy.HashMap;

public class Node 
{
    public int Key { get; set; }
    public int Value { get; set; }

    public Node? Next { get; set; }

    public Node(int key = -1, int value = -1, Node? next = null)
    {
        Key = key;
        Value = value;
        Next = next;
    }
}


public class MyHashMap {

    private Node[] items;

    private int GetIndex(int key)
    {
        return key % items.Length;
    }

    private bool Update(int index, int key, int value) 
    {
        var current = items[index];

        while(current != null) 
        {
            if(current.Key == key) 
            {
                current.Value = value;
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public MyHashMap() 
    {
        items = new Node[10];

        for (int i = 0; i < items.Length; i++)
        {
            items[i] = new Node();
        }
    }

    public void Put(int key, int value)
    {
        int i = GetIndex(key);

        if (!Update(i, key, value))
        {
            items[i].Next = new Node(key, value, items[i].Next);
        }
    }

    public int Get(int key) 
    {
        var current = items[GetIndex(key)];

        while(current != null) 
        {
            if(current.Key == key)  
                return current.Value;

            current = current.Next;
        }
        return -1;
    }
    
    public void Remove(int key) 
    {
        int index = GetIndex(key);
        var current = items[index];

        while(current != null && current.Next !=null) 
        {
            if(current.Next.Key == key) 
            {
                current.Next = current.Next.Next;
                return;
            }
                
            current = current.Next;
        }
    }
}