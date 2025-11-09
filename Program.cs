using LeetCode.Common;
using LeetCode.Problems.Easy;

// Register problems here.
IReadOnlyList<IProblem> problems =
[
    //new TwoSumProblem(),
    new BestTimeBuySellStock()
];

// Solve problems.
foreach (var problem in problems)
{
    var descr = problem.Description;
    
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("═══════════════════════════════════════════════════════════════");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"📝 Problem: {descr.Name}");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"🔗 URL: {descr.Url}");
    Console.WriteLine();
    
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Description:");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"  {descr.Text.Replace("\n", "\n  ")}");
    Console.WriteLine();
    
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Difficulty: ");
    Console.ForegroundColor = descr.Difficulty switch
    {
        Difficulty.Easy => ConsoleColor.Green,
        Difficulty.Medium => ConsoleColor.Yellow,
        Difficulty.Hard => ConsoleColor.Red,
        _ => ConsoleColor.White
    };
    Console.WriteLine(descr.Difficulty);
    Console.WriteLine();
    
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Solutions:");
    Console.ForegroundColor = ConsoleColor.White;
    
    var solutions = problem.Solve();
    
    foreach (var (solution, index) in solutions.Select((s, i) => (s, i + 1)))
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"  [{index}] ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"⏱️  {solution.Duration.TotalMilliseconds:F3} ms");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" → ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(solution.Result);
    }
    
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("═══════════════════════════════════════════════════════════════");
    Console.ResetColor();
    Console.WriteLine();
}