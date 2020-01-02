// 反转链表

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
    public ListNode ReverseList(ListNode pHead)
    {
        // write code here
        if (pHead == null) return null;
        ListNode node = new ListNode(pHead.val);
        pHead = pHead.next;
        while(pHead != null)
        {
            ListNode newHead = new ListNode(pHead.val);
            newHead.next = node;
            node = newHead;
            pHead = pHead.next;
        }
        return node;
    }
}