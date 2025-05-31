namespace CSharp.Easy.Tree;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null!, TreeNode right = null!)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
 

public class BinaryTreeInorderTraversal
{
    private List<int> result = [];
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root is null)
            return result;

        InorderTraversal(root.left);
        result.Add(root.val);
        InorderTraversal(root.right);

        return result;
    }
}
