namespace CSharp.Easy.Tree;


public class MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null)
            return 0;

        int leftMaxDepth = MaxDepth(root.left);
        int rightMaxDepth = MaxDepth(root.right);

        return Math.Max(leftMaxDepth, rightMaxDepth) + 1;
    }
}
