using Algorithms;
using CSharp.DataStructures;

List<int> list = new(10);

// list.Add(1);
// list.Add(2);
list.Add(2);
list.Remove(2);

CustomList<int> customList = new(2);

Console.WriteLine($"List length: {customList.Length}");

customList.Add(1);
customList.Add(2);
customList.Add(3);
customList.Add(4);
customList.Add(5);
customList.Add(6);

customList.Remove();

// customList.RemoveAt(3);
// customList.Remove();
// customList.Remove();

Console.WriteLine($"List length: {customList.Length}");

customList.Add(3);

