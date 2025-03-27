using System.Diagnostics;
using Algorithms;
using CSharp.DataStructures;
using CSharp.Easy.Maths;

var list = new CustomList<string>
{
    "A",
    "B",
    "C",
    "D"
};

list.Remove("C");


foreach (var item in list)
{
    Console.WriteLine(item);
}
