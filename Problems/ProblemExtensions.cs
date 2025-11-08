using System.Diagnostics;

namespace LeetCode.Problems;

public static class ProblemExtensions
{
    public static IList<ProblemResult> Execute<T1, T2, TOutput>(this IReadOnlyList<(T1, T2)> inputValues,
        Func<T1, T2, TOutput> solve, Func<TOutput, string> formatResult)
    {
        return inputValues.Select(testCase =>
        {
            var sw = Stopwatch.StartNew();
            var result = solve(testCase.Item1, testCase.Item2);
            sw.Stop();

            return new ProblemResult
            {
                Duration = sw.Elapsed,
                Result = formatResult(result)
            };
        }).ToList();
    }
}