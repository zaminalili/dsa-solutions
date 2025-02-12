namespace CSharp.DataStuctures;

public class Node<T>
{
    public T val;
    public Node<T> next;
    public Node(T val=default!, Node<T> next=null!) 
    {
        this.val = val;
        this.next = next;
    }
}


public class MyLinkedList<T> 
{
    private Node<T>? Head {get; set;}
    private Node<T>? Tail {get; set;}

    public MyLinkedList()
    {
        Head = null;
        Tail = null;
    }

    public Node<T> AddFirst(T value) 
    {
        Head = new Node<T>(value, Head!);
        if(Tail == null)
            Tail = Head;

        return Head;
    }

    public void AddFirst(Node<T> node) 
    {
        Head = node;
    }

    public Node<T> AddLast(T value) 
    {
        Node<T> newNode = new Node<T>(value);

        if(Head == null)
            Head = newNode;

        else if(Tail == null)
        {
            Tail = newNode;
            Head.next = Tail;
        }
        else 
        {
            var tempNode = Tail;
            Tail = newNode;
            tempNode.next = Tail;
        }

        return newNode;
    }

    public void AddLast(Node<T> node) 
    {
        if(Head == null)
            AddFirst(node);

        else if(Tail == null)
        {
            Tail = node;
            Head.next = Tail;
        }
        else 
        {
            var tempNode = Tail;
            Tail = node;
            tempNode.next = Tail;
        }
            
    }

    public Node<T> AddAfter(Node<T> node, T value) 
    {
        node.next = new Node<T>(value, node.next);

        return node.next;
    }

    public void AddAfter(Node<T> node, Node<T> newNode) 
    {
        node.next = newNode;
    }

    // public Node<T> AddBefore(Node<T> node, T value) 
    // {
    //     new Node<T> (value, node);
    // }

    public void WriteAllValue() 
    {
        var current = Head;

        if(current != null) 
        {
            while(current != null)
            {
                Console.Write($"{current.val} -> ");
                current = current.next;
            }
        }
            
        
    }
}

