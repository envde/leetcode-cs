namespace LeetCode.Problems;

/// <summary>
/// Interface for LeetCode problems.
/// </summary>
public interface IProblem
{
    /// <summary>
    /// Run the problem's solving. Run code with solving logic.
    /// </summary>
    IList<ProblemResult> Solve();
    
    ProblemDescription Description { get; }
}