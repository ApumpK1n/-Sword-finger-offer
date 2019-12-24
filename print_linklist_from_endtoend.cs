// 从尾到头打印链表

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
    // 返回从尾到头的列表值序列
    public List<int> printListFromTailToHead(ListNode listNode)
    {
        // write code here
        List<int> resultList = new List<int>();
        if (listNode == null) return resultList;
        Stack<int> nodeStack = new Stack<int>();
        nodeStack.Push(listNode.val);
        while(listNode.next != null){
            nodeStack.Push(listNode.next.val);
            listNode = listNode.next;
        }

        while(nodeStack.Count > 0){
            resultList.Add(nodeStack.Pop());
        }
        return resultList;
    }
}