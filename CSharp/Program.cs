using CSharp;
using CSharp.DataStuctures;
using CSharp.Easy.HashMap;
using CSharp.Easy.SlidingWindow;
using CSharp.Easy.SuperEasyProblems;
using CSharp.Sorting;

Console.WriteLine("");

string[][] inputs =
[
    ["5", "2", "C", "D", "+"],
    ["5", "-2", "4", "C", "D", "9", "+", "+"],
    ["1", "C"],
    ["10", "20", "C", "+"],
    ["3", "6", "D", "C", "+"]
];

int[] outputs =
[
    30, // [5, 10, 15] -> 30
    27, // [5, -2, -4, 9, 5, 14] -> 27
    0,  // [] -> 0
    30, // [10, 10] -> 30
    9   // [3, 6] -> 9
];




BaseballGame s = new();

   
for (int i = 0; i < inputs.Length; i++)
{
    int result = s.CalPoints(inputs[i]);
    Console.WriteLine($"Test {i + 1}: {(result == outputs[i] ? "✅ Passed" : "❌Failed")}");
}
