// 二叉树的下一个结点

/*
public class TreeLinkNode
{
    public int val;
    public TreeLinkNode left;
    public TreeLinkNode right;
    public TreeLinkNode next;
    public TreeLinkNode (int x)
    {
        val = x;
    }
}*/
class Solution
{
    public TreeLinkNode GetNext(TreeLinkNode pNode)
    {
        // write code here
        if(pNode == null) return null;
        else if(pNode.right != null) // 有右子节点, 找最左节点。
        {
            pNode = pNode.right;
            while(pNode.left != null)
            {
                pNode = pNode.left;
            }
            return pNode;
        }
        else
        {
            if (pNode.next!=null && pNode.next.left == pNode) return pNode.next; // 为左子节点，找父节点。
            else if (pNode.next!=null && pNode.next.right == pNode)
            {
                while(pNode.next != null && pNode.next.left != pNode)
                {
                    pNode = pNode.next;
                }
                return pNode.next;
            }//为右节点，向上遍历找到左子节点为该父节点的节点
            return pNode.next;
        }
    }
}