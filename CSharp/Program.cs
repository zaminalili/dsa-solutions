using CSharp;
using CSharp.DataStuctures;

Console.WriteLine("");

// Stack<int> s = new Stack<int>();

// s.Peek();

// s.Pop();


MyStack<int> stack = new();

stack.Write();

stack.Push(1);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);
stack.Push(2);


stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();

stack.Push(8);
stack.Push(9);

stack.Write();