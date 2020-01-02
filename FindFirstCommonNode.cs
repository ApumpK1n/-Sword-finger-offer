//两个链表的第一个公共结点

/*
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode (int x)
    {
        val = x;
    }
}*/
class Solution
{
    public ListNode FindFirstCommonNode(ListNode pHead1, ListNode pHead2)
    {
        // write code here
        ListNode oneTreeNode = pHead1;
        ListNode twoTreeNode = pHead2;
        if (pHead1 == null || pHead2 == null) return null;
        while(oneTreeNode != null)
        {
            if (twoTreeNode == null) 
            {
                oneTreeNode = oneTreeNode.next;
                twoTreeNode = pHead2;
            }
            else if (oneTreeNode.val == twoTreeNode.val)
            {
                return oneTreeNode;
            }
            else
            {
                twoTreeNode = twoTreeNode.next;
            }
        }
        return null;
    }
}