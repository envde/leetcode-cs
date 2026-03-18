namespace LeetCode.Common;

/// <summary>
/// Extension methods for converting arrays to LeetCode-style strings.
/// </summary>
public static class ArrayExtensions
{
    /// <summary>
    /// Converts array to LeetCode-style string representation: [1, 2, 3]
    /// </summary>
    public static string ToLeetCodeString<T>(this T[] array)
    {
        return $"[{string.Join(", ", array)}]";
    }

    /// <summary>
    /// Converts enumerable to LeetCode-style string representation: [1, 2, 3]
    /// </summary>
    public static string ToLeetCodeString<T>(this IEnumerable<T> enumerable)
    {
        return $"[{string.Join(", ", enumerable)}]";
    }

    /// <summary>
    /// Converts 2D array to LeetCode-style string representation: [[1,2],[3,4]]
    /// </summary>
    public static string ToLeetCodeString<T>(this T[][] array)
    {
        var rows = array.Select(row => $"[{string.Join(",", row)}]");
        return $"[{string.Join(",", rows)}]";
    }

    /// <summary>
    /// Converts list to LeetCode-style string representation: [1, 2, 3]
    /// </summary>
    public static string ToLeetCodeString<T>(this IList<T> list)
    {
        return $"[{string.Join(", ", list)}]";
    }
}