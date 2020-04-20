//删除链表中重复的结点

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
    public ListNode deleteDuplication(ListNode pHead)
    {
        // write code here
        if(pHead==null)return pHead;
        if(pHead!=null&&pHead.next==null)return pHead;
         
        ListNode p=null;
        if(pHead.val==pHead.next.val){
            p=pHead.next.next;
            while(p!=null&&p.val==pHead.val){
                p=p.next;
            }
            return deleteDuplication(p);
             
        }else{
            p=pHead.next;
            pHead.next=deleteDuplication(p);
            return pHead;
             
        }
         
    }
}
