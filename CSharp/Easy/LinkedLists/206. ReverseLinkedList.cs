namespace CSharp.Easy.Array;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null!) 
    {
        this.val = val;
        this.next = next;
    }
}

public class ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode next = null;

        while (head != null)
        {
            next = new ListNode(head.val, next);
            head = head.next;
        }

        return next;
    }
}
