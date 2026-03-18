namespace LeetCode.Common;

/// <summary>
/// Problem result.
/// </summary>
public record struct ProblemResult {
    /// <summary>
    /// Time taken to solve the problem.
    /// </summary>
    public required TimeSpan Duration { get; init; }
    /// <summary>
    /// Problem's result.'
    /// </summary>
    public required string Result { get; init; }

    /// <summary>
    /// The expected outcome of the problem solution.
    /// </summary>
    public required string? Expected { get; init; }
}