// 链表中倒数第k个结点

using System.Collections.Generic;

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
    public ListNode FindKthToTail(ListNode head, int k)
    {
        // write code here
        if (head == null) return null;
        if (k <= 0) return null;
        Stack<ListNode> stack = new Stack<ListNode>();
        int num = 0;
        while(head != null)
        {
            stack.Push(head);
            num += 1;
            head = head.next;
        }
        if (num < k) return null;
        for(int i=0; i<k-1; i++)
        {
            stack.Pop();
        }
        return stack.Pop();
    }
}