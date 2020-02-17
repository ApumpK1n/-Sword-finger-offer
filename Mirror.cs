//二叉树的镜像 

/*
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x)
    {
        val = x;
    }
}*/
class Solution
{
    public TreeNode Mirror(TreeNode root)
    {
        // write code here
        if (root == null) return root;
        TreeNode nodeRight = Mirror(root.left); // 左右子树分别递归
        TreeNode nodeLeft = Mirror(root.right);
        root.left = nodeLeft;
        root.right = nodeRight;
        return root;
    }
}