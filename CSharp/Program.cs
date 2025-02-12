using CSharp.DataStuctures;

Console.WriteLine("");
LinkedList<int> ints = new();

var head = ints.AddLast(1);
var curr = ints.AddLast(2);
ints.AddLast(3);


// foreach (var item in ints)
// {
//     Console.WriteLine(item.ToString());
// }

MyLinkedList<int> list = new();

// System.Console.WriteLine(list.AddLast(1).val);
var node = list.AddLast(1);
list.AddLast(2);
list.AddLast(3);
list.AddLast(4);

list.AddAfter(node, 100);



list.WriteAllValue();



// ListNode<int> node4 = new ListNode<int>(4);
// ListNode<int> node3 = new ListNode<int>(3, node4);
// ListNode<int> node2 = new ListNode<int>(2, node3);
// ListNode<int> node1 = new ListNode<int>(1);

// var head = node1;

// head.AddValueToNext(2);
// head.AddValueToNext(3);
// head.AddValueToNext(4);
// head.AddValueToNext(5);

// 1 -> 5 -> 4 -> 3 -> 2

// while (head.next != null) 
// {
//     Console.WriteLine(head.val);
//     head = head.next;
// }