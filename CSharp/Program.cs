using CSharp.Sorting;

var nums = new int[] { 5, 7, 2, 9, 6, 1, 3, 7};

var result = CountingSort.SortAsc(nums);

foreach (var num in result)
{
    Console.WriteLine(num);
}