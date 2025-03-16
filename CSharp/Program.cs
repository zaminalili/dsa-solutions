using System.Diagnostics;
using Algorithms;
using CSharp.DataStructures;
using CSharp.Easy.Maths;

ExcelSheetColumnTitle s = new();

long totalElapsedMS = 0;
int count = 1000;

for (int i = 1; i <= count; i++)
{
    var stopwatch =  Stopwatch.StartNew();

    s.ConvertToTitle(i);

    stopwatch.Stop();
    totalElapsedMS += stopwatch.ElapsedMilliseconds;
}

Console.WriteLine($"Mean: {totalElapsedMS/count} ms");

