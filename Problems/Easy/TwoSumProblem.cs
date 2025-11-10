using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class TwoSumProblem : IProblem
{
    public IList<ProblemResult> Solve()
    {
        IReadOnlyList<(int[] Nums, int Target, int[] Expected)> inputValues =
        [
            ([2, 7, 11, 15], 9, [0,1]),
            ([3, 2, 4], 6, [1,2]),
            ([3, 1], 6, [0,1])
        ];

        var problemResults = inputValues.Execute(TwoSumFast, result => $"[{string.Join(", ", result)}]");

        return problemResults;
    }

    public ProblemDescription Description => new()
    {
        Name = "Two Sum",
        Url = "https://leetcode.com/problems/two-sum/",
        Text =
            "Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.\n" +
            "You may assume that each input would have exactly one solution, and you may not use the same element twice.\n" +
            "You can return the answer in any order.",
        Difficulty = Difficulty.Easy
    };


    /*
       Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
       You may assume that each input would have exactly one solution, and you may not use the same element twice.
       You can return the answer in any order.

       Example 1:

       Input: nums = [2,7,11,15], target = 9
       Output: [0,1]
       Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
       Example 2:

       Input: nums = [3,2,4], target = 6
       Output: [1,2]
       Example 3:

       Input: nums = [3,3], target = 6
       Output: [0,1]

       Constraints:

       2 <= nums.length <= 104
       -109 <= nums[i] <= 109
       -109 <= target <= 109
       Only one valid answer exists.


       Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
    */
    private static int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (i == j) continue;

                if (nums[i] + nums[j] == target)
                    return [i, j];
            }
        }

        return [];
    }

    private static int[] TwoSumFast(int[] nums, int target)
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