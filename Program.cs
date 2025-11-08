using LeetCode.Problems;
using LeetCode.Problems.Easy;

IReadOnlyList<IProblem> problems =
[
    new TwoSumProblem()
];

foreach (var problem in problems)
{
    var descr = problem.Description;
    Console.WriteLine($"Problem: {descr.Name}");
    Console.WriteLine($"URL: {descr.Url}");
    Console.WriteLine($"Description:\n{descr.Text}");
    Console.WriteLine($"Difficulty: {descr.Difficulty}");
    Console.WriteLine("Solutions:");

    var solutions = problem.Solve();

    foreach (var solution in solutions)
    {
        Console.WriteLine($"Time: {solution.Duration:c}, Result: {solution.Result}");
    }
    
    Console.WriteLine();
}