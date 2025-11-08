namespace LeetCode.Common;

/// <summary>
/// Description of the problem.
/// </summary>
public record struct ProblemDescription
{
    /// <summary>
    /// Problem's name.
    /// </summary>
    public required string Name { get; init; }
    /// <summary>
    /// Problem's url.'
    /// </summary>
    public required string Url { get; init; }
    /// <summary>
    /// Text to describe the problem.
    /// </summary>
    public required string Text { get; init; }
    /// <summary>
    /// Problem's difficulty.'
    /// </summary>
    public required Difficulty Difficulty { get; init; }
}