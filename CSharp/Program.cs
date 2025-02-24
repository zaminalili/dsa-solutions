using CSharp;
using CSharp.DataStuctures;
using CSharp.Easy.HashMap;
using CSharp.Easy.SlidingWindow;
using CSharp.Easy.SuperEasyProblems;
using CSharp.Sorting;

Console.WriteLine("");

int[,] inputs = {
    {5, 5, 5}, 
    {5, 5, 3},   
    {4, 5, 6},   
    {1, 2, 3},   
    {1, 1, 1},   
    {1000000, 999999, 999998}, 
    {10, 10, 25},
    {0, 4, 4}, 
    {-3, 4, 5},
    {999, 999, 1},
    {10, 2, 7} 
};

string[] outputs = {
    "equilateral",
    "isosceles",
    "scalene",
    "none",
    "equilateral",
    "scalene",
    "none",
    "none",
    "none",
    "isosceles",
    "none"
};

TypeOfTriangle s = new();

for (int i = 0; i < inputs.GetLength(0); i++)
{
    int a = inputs[i, 0], b = inputs[i, 1], c = inputs[i, 2];
    int[] input = [a, b, c];
    string expected = outputs[i];
    string result = s.TriangleType(input);

    if (result == expected)
        Console.WriteLine($"✅ Test {i + 1} Passed: [{a}, {b}, {c}] → {result}");
    else
        Console.WriteLine($"❌ Test {i + 1} Failed: [{a}, {b}, {c}] → Expected: {expected}, Got: {result}");
}    
