using System.Diagnostics;

namespace LeetCode.Common;

/// <summary>
/// Extension methods for problems.
/// </summary>
public static class ProblemExtensions
{
    /// <summary>
    /// Executes the problem-solving logic for a collection of input tuples using specified solve and result formatting functions.
    /// </summary>
    /// <param name="inputValues">A collection of input tuples, each containing two elements of types T1 and T2.</param>
    /// <param name="solve">A function that defines the solving logic, accepting two parameters of types T1 and T2, and returning a result of type TOutput.</param>
    /// <param name="formatResult">A function that formats the resulting output of type TOutput into a string representation.</param>
    /// <typeparam name="T1">The type of the first element in the input tuple.</typeparam>
    /// <typeparam name="T2">The type of the second element in the input tuple.</typeparam>
    /// <typeparam name="T3">Expected value</typeparam>
    /// <typeparam name="TOutput">The type of the output result produced by the solve function.</typeparam>
    /// <returns>A list of ProblemResult, where each result represents a test case including its execution duration and formatted output string.</returns>
    public static IList<ProblemResult> Execute<T1, T2, T3, TOutput>(this IReadOnlyList<(T1, T2, T3)> inputValues,
        Func<T1, T2, TOutput> solve, Func<TOutput, string> formatResult) where T3 : TOutput
    {
        return inputValues.Select(testCase =>
        {
            var sw = Stopwatch.StartNew();
            var result = solve(testCase.Item1, testCase.Item2);
            sw.Stop();

            return new ProblemResult
            {
                Duration = sw.Elapsed,
                Result = formatResult(result),
                Expected = formatResult(testCase.Item3)
            };
        }).ToList();
    }

    /// <summary>
    /// Executes the problem-solving logic for a given set of input values using specified solve and formatResult functions.
    /// </summary>
    /// <param name="inputValues">A collection of input values consisting of tuples of two elements.</param>
    /// <param name="solve">A function that defines the solving logic, accepting two parameters of types T1 and T2, and returning a result of type TOutput.</param>
    /// <param name="formatResult">A function that formats the output result of type TOutput into a string representation.</param>
    /// <typeparam name="T1">The type of the first element in the input tuple.</typeparam>
    /// <typeparam name="T2">Expected value</typeparam>
    /// <typeparam name="TOutput">The type of the output result after applying the solve function.</typeparam>
    /// <returns>A list of ProblemResult, representing the results of each test case including the execution duration and formatted output.</returns>
    public static IList<ProblemResult> Execute<T1, T2, TOutput>(this IReadOnlyList<(T1, T2)> inputValues,
        Func<T1, TOutput> solve, Func<TOutput, string> formatResult) where T2 : TOutput
    {
        return inputValues.Select(testCase =>
        {
            var sw = Stopwatch.StartNew();
            var result = solve(testCase.Item1);
            sw.Stop();

            return new ProblemResult
            {
                Duration = sw.Elapsed,
                Result = formatResult(result),
                Expected = formatResult(testCase.Item2)
            };
        }).ToList();
    }
}