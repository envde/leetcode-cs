using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class TwoSumProblem: ProblemDefault<(int[] Nums, int Target, int[] Expected)>
{
    protected override (string Result, string Expected) Execute((int[] Nums, int Target, int[] Expected) inputItem)
    {
        var result = TwoSum(inputItem.Nums, inputItem.Target);
        return (result.ToLeetCodeString(), inputItem.Expected.ToLeetCodeString());
    }

    public override ProblemDescription Description => new()
    {
        Name = "Two Sum",
        Url = "https://leetcode.com/problems/two-sum/",
        Difficulty = Difficulty.Easy
    };

    protected override IReadOnlyList<(int[] Nums, int Target, int[] Expected)> InputValues =>
    [
        ([2, 7, 11, 15], 9, [0, 1]),
        ([3, 2, 4], 6, [1, 2]),
        ([3,3], 6, [0, 1])
    ];

    
    private static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (map.TryGetValue(diff, out var diffIndex))
            {
                return [diffIndex, i];
            }

            map.TryAdd(nums[i], i);
        }

        return [];
    }
}