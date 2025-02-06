Console.WriteLine("Hello, LinkedList");

ListNode node4 = new ListNode(4);
ListNode node3 = new ListNode(3, node4);            // Düyün 3 (-> null)
ListNode node2 = new ListNode(2, node3);     // Düyün 2 -> 3
ListNode node1 = new ListNode(1, node2);     // Düyün 1 -> 2 -> 3

// ListNode rnode4 = new ListNode(node1.val);
// ListNode rnode3 = new ListNode(node1.next.val, rnode4);
// ListNode rnode2 = new ListNode();


// val = next.val

ListNode current = node1;
ListNode? next = null;

while (current != null)
{
    //Console.WriteLine($"{current.val}");

    ListNode newNode = new ListNode(current.val, next);

    next = newNode;
    current = current.next;
}

Console.WriteLine($"new {next!.next}");

