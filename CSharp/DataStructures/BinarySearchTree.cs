namespace CSharp.DataStructures;

public class BstNode<T>
{
    public T Data {get; set;}
    public BstNode<T> Left {get; set;}
    public BstNode<T> Right {get; set;}

    public BstNode(T data)
    {
        Data = data;
        Left = default!;
        Right = default!;
    }
}

public class BinarySearchTree<T> where T : IComparable
{
    private BstNode<T> root;

    public BinarySearchTree()
    {
        root = default!;
    }

    private BstNode<T> InsertRec(BstNode<T> root, T data) 
    {
        if(root == null)
            return new BstNode<T>(data);

        if(root.Data.CompareTo(data) > 0) 
            root.Left = InsertRec(root.Left, data);
        else
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    private void TraversalInOrdeRec(BstNode<T> node) 
    {
        if(node == null)
            return;

        TraversalInOrdeRec(node.Left);
        Console.WriteLine(node.Data);
        TraversalInOrdeRec(node.Right);
        
    }

    private void TraversalPreOrderRec(BstNode<T> node) 
    {
        if(node==null)
            return;

        Console.WriteLine(node.Data);
        TraversalPreOrderRec(node.Left);
        TraversalPreOrderRec(node.Right);
    }


    public void Insert(T data)
    {
        root = InsertRec(root, data);
    }

    public void TraversalInOrder() 
    {
       TraversalInOrdeRec(root);
    }

    public void TraversalPreOrder() 
    {
        TraversalPreOrderRec(root);
    }
}
