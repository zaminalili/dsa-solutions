namespace CSharp.Easy.Tree;

public class InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root is not null)
        {
            (root.right, root.left) = (root.left, root.right);
            InvertTree(root.left);
            InvertTree(root.right);
        }

        return root!;   
    }
}
