namespace CSharp.Easy.Tree;

public class BinaryTreePreorderTraversal
{
    private List<int> result = [];
    public IList<int> PreorderTraversal(TreeNode root)
    {
        if (root is null)
            return result;

        result.Add(root.val);
        PreorderTraversal(root.left);
        PreorderTraversal(root.right);

        return result;
    }
}
