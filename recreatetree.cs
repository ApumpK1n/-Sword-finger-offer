// 重建二叉树

//将队列切分为左右子树，再对左右子树做同样处理，直到构建出二叉树。

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
    public TreeNode reConstructBinaryTree(int[] pre, int[] tin)
    {
        // write code here
        return reBulidBinaryTree(pre, 0, pre.Length -1, tin, 0, tin.Length-1);
    }

    private TreeNode reBulidBinaryTree(int[] pre, int startpre, int endpre, int[] tin, int starttin, int endtin)
    {
        if (startpre > endpre || starttin > endtin) return null;
        TreeNode treeNode = new TreeNode(pre[startpre]);
        for(int index=starttin; index <= endtin; index++)
        {
            if (tin[index] == pre[startpre])
            {
                treeNode.left = reBulidBinaryTree(pre, startpre+1, startpre + index - starttin, tin, starttin, index);
                treeNode.right = reBulidBinaryTree(pre, index - starttin + startpre +1, endpre, tin, index+1, endtin);
            }
        }
        return treeNode;
    }
}