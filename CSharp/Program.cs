using System.Diagnostics;
using Algorithms;
using CSharp.DataStructures;
using CSharp.Easy.BitManipulation;
using CSharp.Easy.Maths;

var s = new Solution1304();

var nums = s.SumZero(1000);
int sum = 0;
foreach (int num in nums)
{
    Console.WriteLine(num);
    sum += num;
}

Console.WriteLine("Sum: "+ sum);