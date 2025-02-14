using CSharp;
using CSharp.DataStuctures;

Console.WriteLine("");

// Queue<int> ints= new Queue<int>();
// ints.Dequeue();

MyQueue<int> queue = new(3);

// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);
// queue.Enqueue(4);
// queue.Dequeue();
// queue.Enqueue(5);
// queue.Dequeue();
// queue.Dequeue();

Console.WriteLine($"Count: {queue.Count()}");

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);
queue.Enqueue(7);
queue.Enqueue(8);
queue.Enqueue(9);

Console.WriteLine($"Count: {queue.Count()}");

queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();

queue.Dequeue();
 queue.Dequeue();

var last = queue.Dequeue();

Console.WriteLine($"Last: {last}");

queue.Write();
// queue.Enqueue(4);