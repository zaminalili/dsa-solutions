namespace SolutionWithCsharp;

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
