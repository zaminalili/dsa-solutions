using CSharp;
using CSharp.DataStuctures;
using CSharp.Easy.HashMap;
using CSharp.Easy.SlidingWindow;
using CSharp.Easy.SuperEasyProblems;
using CSharp.Sorting;

Console.WriteLine("");

int[] nums = [19,3,25,12,7];
int[] nums2 = [55,30,8,41,22,14];
int[] nums3 = [34,9,5,23,29,2,16];
int[] nums4 = [50,71,11,62,27,44,18,35];
int[] nums5 = [42,6,31,67,13,21,53];

nums = SelectionSort.SortDesc(nums2);

//string output = "";

foreach (var num in nums)
{
    Console.WriteLine($"{num}");
}

