namespace LeetCode.Common;

/// <summary>
/// Handles formatted console output for LeetCode problems.
/// </summary>
public static class ConsoleRenderer
{
    /// <summary>
    /// Renders a single problem with its description and solutions.
    /// </summary>
    public static void RenderProblem(IProblem problem)
    {
        var description = problem.Description;
        
        RenderHeader(description);
        RenderDifficulty(description.Difficulty);
        RenderSolutions(problem.Solve());
        RenderFooter();
    }

    /// <summary>
    /// Renders multiple problems.
    /// </summary>
    public static void RenderProblems(IEnumerable<IProblem> problems)
    {
        foreach (var problem in problems)
        {
            RenderProblem(problem);
        }
    }

    private static void RenderHeader(ProblemDescription description)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("══════════════════════════════════════════════════════════════════════════════");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"📝 Problem: {description.Name}");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"🔗 URL: {description.Url}");
        Console.WriteLine();
        Console.ResetColor();
    }

    private static void RenderDifficulty(Difficulty difficulty)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Difficulty: ");
        Console.ForegroundColor = difficulty switch
        {
            Difficulty.Easy => ConsoleColor.Green,
            Difficulty.Medium => ConsoleColor.Yellow,
            Difficulty.Hard => ConsoleColor.Red,
            _ => ConsoleColor.White
        };
        Console.WriteLine(difficulty);
        Console.WriteLine();
        Console.ResetColor();
    }

    private static void RenderSolutions(IList<ProblemResult> solutions)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Solutions:");
        Console.ResetColor();

        foreach (var (solution, index) in solutions.Select((s, i) => (s, i + 1)))
        {
            RenderSolution(solution, index);
        }
    }

    private static void RenderSolution(ProblemResult solution, int index)
    {
        var isCorrect = solution.Result == solution.Expected;

        // Test number
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"  [{index}] ");

        // Duration
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"⏱️  {solution.Duration.TotalMilliseconds:F3} ms");

        // Arrow
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" → ");

        // Result label
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Result: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(solution.Result);

        // Separator
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" | ");

        // Expected label
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Expected: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(solution.Expected);

        // Status icon
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" ");
        Console.ForegroundColor = isCorrect ? ConsoleColor.Green : ConsoleColor.Red;
        Console.Write(isCorrect ? "✓" : "✗");

        Console.WriteLine();
        Console.ResetColor();
    }

    private static void RenderFooter()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.ResetColor();
        Console.WriteLine();
    }
}