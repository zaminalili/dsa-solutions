using CSharp;
using CSharp.DataStuctures;
using CSharp.Easy.HashMap;
using CSharp.Easy.SlidingWindow;

Console.WriteLine("");

int[] nums = { 1, 12,-5,-6,50, 3};
int k = 4;

int[] nums2 = {5};
int k2 = 1;

Console.WriteLine(MaximumAverageSubarray.FindMaxAverage(nums, k));
Console.WriteLine(MaximumAverageSubarray.FindMaxAverage(nums2, k2));