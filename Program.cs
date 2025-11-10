using LeetCode.Common;
using LeetCode.Problems.Easy;

// Register problems here.
IReadOnlyList<IProblem> problems =
[
    new TwoSumProblem(),
    new BestTimeBuySellStock(),
    new MaximumSubarray()
];

ConsoleRenderer.RenderProblems(problems);