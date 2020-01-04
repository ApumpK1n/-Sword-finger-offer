// 合并两个单调递增的链表，输出合并后单调递增的链表

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
    public ListNode Merge(ListNode pHead1, ListNode pHead2)
    {
        // write code here
        if (pHead1 == null) return pHead2;
        if (pHead2 == null) return pHead1;
        if (pHead1.val <= pHead2.val)
        {
            pHead1.next = Merge(pHead1.next, pHead2);
            return pHead1;
        }
        else 
        {
            pHead2.next = Merge(pHead1, pHead2.next);
            return pHead2;
        }
    }
}