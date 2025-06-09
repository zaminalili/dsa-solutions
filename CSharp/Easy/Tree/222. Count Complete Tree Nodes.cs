namespace CSharp.Easy.Tree;

public class CountCompleteTreeNodes
{
    public int CountNodes(TreeNode root)
    {
        if (root is null)
            return 0;

        int leftCount = CountNodes(root.left);
        int rightCount = CountNodes(root.right);

        return leftCount + rightCount + 1;    
    }
}
