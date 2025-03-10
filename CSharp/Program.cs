using CSharp;
using CSharp.DataStuctures;
using CSharp.Easy.HashMap;
using CSharp.Easy.SlidingWindow;
using CSharp.Easy.SuperEasyProblems;
using CSharp.Sorting;

Console.WriteLine("");

int[] nums= [5, 4, 3, 2, 1];
int[] nums2= [85, 12, 59, 45, 72, 51];

nums = InsertionSort.SortAsc(nums2);

foreach (var num in nums)
{
    Console.WriteLine(num);
}