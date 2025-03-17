using System.Diagnostics;
using Algorithms;
using CSharp.DataStructures;
using CSharp.Easy.Maths;

ExcelSheetColumnNumber s = new();

//s.TitleToNumber("W");
Console.WriteLine(s.TitleToNumber("A"));
Console.WriteLine(s.TitleToNumber("AB"));
Console.WriteLine(s.TitleToNumber("ZY"));
Console.WriteLine(s.TitleToNumber("XFD")); // 16384
Console.WriteLine(s.TitleToNumber("Z")); // 
Console.WriteLine(s.TitleToNumber("AZ")); // 


