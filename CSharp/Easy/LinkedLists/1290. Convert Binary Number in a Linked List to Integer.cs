namespace CSharp.Easy.LinkedLists;

public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) 
    {
          this.val = val;
          this.next = next;
    }
}

public class Solution1290
{
    public int GetDecimalValue(ListNode head) 
    {
        var value = 0;

        while (head != null) 
        {
            value = (value << 1) + head.val;
            head = head.next;
        }

        return value;    
    }
}
