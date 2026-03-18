using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class MaximumSubarray: ProblemDefault<(int[] Data, int Expected)>
{
    protected override (string Result, string Expected) Execute((int[] Data, int Expected) inputItem)
    {
        var result = MaxSubArray(inputItem.Data);
        return (result.ToString(), inputItem.Expected.ToString());
    }

    public override ProblemDescription Description => new()
    {
        Name = "Maximum Subarray",
        Url = "https://leetcode.com/problems/maximum-subarray/",
        Difficulty = Difficulty.Easy
    };

    protected override IReadOnlyList<(int[] Data, int Expected)> InputValues =>
    [
        ([-2, 1, -3, 4, -1, 2, 1, -5, 4], 6),
        ([1], 1),
        ([5, 4, -1, 7, 8], 23)
    ];

    
    private static int MaxSubArray(int[] nums) {
        var maxSum = nums[0];
        var currentSum = nums[0];

        for (var i = 1; i < nums.Length; i++) {

            var num = nums[i];

            if (currentSum + num < num) {
                currentSum = num;
            }
            else 
                currentSum += num;

            
            if (currentSum > maxSum)
                maxSum = currentSum;
        }

        return maxSum;
    }
}