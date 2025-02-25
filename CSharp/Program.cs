using CSharp;
using CSharp.DataStuctures;
using CSharp.Easy.HashMap;
using CSharp.Easy.SlidingWindow;
using CSharp.Easy.SuperEasyProblems;
using CSharp.Sorting;

Console.WriteLine("");

int[] nums = [-4,-1,0,3,10];



SquaresOfASortedArray s = new();

   
nums = s.SortedSquares(nums);

foreach (var num in nums)
{
    Console.WriteLine(num);
}