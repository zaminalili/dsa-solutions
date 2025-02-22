using CSharp;
using CSharp.DataStuctures;
using CSharp.Easy.HashMap;
using CSharp.Easy.SlidingWindow;
using CSharp.Easy.SuperEasyProblems;
using CSharp.Sorting;

Console.WriteLine("");

CountTheDigitsThatDivideANumber solution = new();

int num1 = 7;
int num2 = 121;
int num3 = 1248;

Console.WriteLine(solution.CountDigits(num1));
Console.WriteLine(solution.CountDigits(num2));
Console.WriteLine(solution.CountDigits(num3));
