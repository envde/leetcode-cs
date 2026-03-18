using System.Diagnostics;

namespace LeetCode.Common;

public abstract class ProblemDefault<T>: IProblem
{
    public virtual IList<ProblemResult> Solve()
    {
        IList<ProblemResult> problemResults = new List<ProblemResult>();
        foreach (var inputItem in InputValues)
        {
            var sw = Stopwatch.StartNew();
            var executeResult = Execute(inputItem);
            sw.Stop();
            
            var problemResult = new ProblemResult
            {
                Duration = sw.Elapsed,
                Result = executeResult.Result,
                Expected = executeResult.Expected
            };
            
            problemResults.Add(problemResult);
        }
        

        return problemResults;
    }
    
    protected abstract (string Result, string Expected) Execute(T inputItem);

    public virtual ProblemDescription Description => default;

    protected abstract IReadOnlyList<T> InputValues { get; }
}