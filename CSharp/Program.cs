using CSharp.Easy.Stackes;

var validParantheses = new ValidParentheses();

string input1 = "()";
string input2 = "()[]{}";
string input3 = "(]";
string input4 = "([])";
string input5 = "]";

Console.WriteLine(validParantheses.IsValid(input1));
Console.WriteLine(validParantheses.IsValid(input2));
Console.WriteLine(validParantheses.IsValid(input3));
Console.WriteLine(validParantheses.IsValid(input4));
Console.WriteLine(validParantheses.IsValid(input5));