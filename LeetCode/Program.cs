using LeetCode.Common;
using LeetCode.Outline;
using LeetCode.Problems.Easy;
using LeetCode.Problems.Medium;

// Register problems here.
IReadOnlyList<IProblem> problems =
[
    // new TwoSumProblem(),
    // new BestTimeBuySellStock(),
    // new MaximumSubarray(),
    // new MergeSortedArray(),
    // new RemoveDuplicatesSortedArray(),
    // new RemoveDuplicatesSortedArray2(),
    // new RemoveElement(),
    //new MoveZeroes()
];

//ConsoleRenderer.RenderProblems(problems);

SortedArray<int> myArray = new SortedArray<int>();
myArray.Insert(1);
myArray.Insert(2);
myArray.Insert(3);
myArray.Insert(5);
myArray.Insert(6);
myArray.Insert(7);
myArray.Insert(4);
myArray.Insert(8);
myArray.Insert(9);

myArray.Delete(4);