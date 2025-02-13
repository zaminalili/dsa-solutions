namespace CSharp.DataStuctures;

public class Node<T>
{
    public T val;
    public Node<T> previous;
    public Node<T> next;
    public Node(T val=default!, Node<T> next=null!, Node<T> previous = null!) 
    {
        this.val = val;
        this.previous = previous;
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
        var newNode = new Node<T>(value, Head!);
        
        if(Head != null) 
            Head.previous = newNode;
        
        Head = newNode;

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
            Tail.previous = tempNode;
        }

        return newNode;
    }

    public void AddLast(Node<T> node) 
    {
        Tail = node;
    }

    public Node<T> AddAfter(Node<T> node, T value) 
    {
        var newNode = new Node<T>(value, node.next, node);
        
        if(node.next == null)
            Tail = newNode;
        else
            node.next.previous = newNode;

        node.next = newNode;

        return newNode;
    }

    public void AddAfter(Node<T> node, Node<T> newNode) 
    {
        node.next = newNode;
    }

    public Node<T> AddBefore(Node<T> node, T value) 
    {
        var newNode = new Node<T> (value, node, node.previous);

        if(node.previous == null)
            Head = newNode;
        else
            node.previous.next = newNode;
    
        node.previous = newNode;

        return newNode;
    }

    public void RemoveFirst() 
    {
        if(Head != null) 
        {
            Head = Head.next;
            Head.previous = null!;
        }
    }

    public void RemoveLast() 
    {
        if(Tail != null) 
        {
            Tail = Tail.previous;
            Tail.next = null!;
        }
    }

    public bool Remove(T value) 
    {
        var current = Head;

        while(current != null)
        {
            if(Head!.val!.ToString() == value!.ToString())
            {
                RemoveFirst();
                return true;
            }
            else if(Tail!.val!.ToString() == value!.ToString()) 
            {
                RemoveLast();
                return true;
            }

            else if(current.val!.ToString() == value!.ToString()) 
            {
                current.next.previous = current.previous;
                current.previous.next = current.next;
                return true;
            }
            current = current.next;
        } 

        return false;
    }



    public void WriteAllValue() 
    {
        var current = Head;

        while(current != null)
        {
            Console.Write($"{current.val} <-> ");
            current = current.next;
        } 
    }
}

