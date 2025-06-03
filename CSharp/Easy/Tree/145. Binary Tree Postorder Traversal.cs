namespace CSharp.Easy.Tree;

public class BinaryTreePostorderTraversal
{
    private List<int> result = [];

    public IList<int> PostorderTraversal(TreeNode root)
    {
        if (root is null)
            return result;

        PostorderTraversal(root.left);
        PostorderTraversal(root.right);
        result.Add(root.val);

        return result;
    }
}
