﻿using CSharp;
using CSharp.DataStuctures;
using CSharp.Easy.HashMap;
using CSharp.Easy.SlidingWindow;
using CSharp.Easy.SuperEasyProblems;
using CSharp.Sorting;

Console.WriteLine("");

int[] nums1 = [1,15,6,3,10];
int[] nums2 = [1,2,3,4];
int[] nums3 = [12,97,48,72,31,70,1,9,78,28,1,30,82,17,43,44,53,12,73,16,74,24,79,9,51,77,36,38,81,38,69,60,29,21,66,6,62,55,13,90,66,7,15,15,60,76,44,30,6,86,87,59,88,36,32,35,67,13,79,43,27,2,97,41,4,44,91,11,5,48,38,64,9,90,39,28,50,57,60,4,99,44,39,12,95,32,66,100,45,42,22,35,65,7,49,43,41,40,64,78];

DifferenceBetweenElementSumAndDigitSumOfAnArray s = new();

Console.WriteLine(s.DifferenceOfSum(nums1));
// Console.WriteLine(s.DifferenceOfSum(nums2));
// Console.WriteLine(s.DifferenceOfSum(nums3));