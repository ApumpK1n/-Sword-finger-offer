// 树的子结构

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
    public bool HasSubtree(TreeNode pRoot1, TreeNode pRoot2)
    {
        // write code here
        if (pRoot1 == null) return false;
        if (pRoot2 == null) return false;
        return IsSubTree(pRoot1, pRoot2);
    }

    public bool IsSubTree(TreeNode pNode1, TreeNode pNode2)
    {
        if (pNode2 == null) return true;
        if (pNode1 == null) return false;

        if (pNode1.val == pNode2.val)
        {
           if (IsSubTree(pNode1.left, pNode2.left) && IsSubTree(pNode1.right, pNode2.right)) return true;
        }
        return IsSubTree(pNode1.left, pNode2) || IsSubTree(pNode1.right, pNode2);
    }
}