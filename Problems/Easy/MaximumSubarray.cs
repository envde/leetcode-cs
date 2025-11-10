using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class MaximumSubarray: IProblem
{
    public IList<ProblemResult> Solve()
    {
        IReadOnlyList<(int[], int)> inputValues =
        [
            ([-2,1,-3,4,-1,2,1,-5,4], 6),
            ([1], 1),
            ([5,4,-1,7,8], 23)
        ];
        
        var problemResults = inputValues.Execute(MaxSubArray, result => result.ToString());
        return problemResults;
    }

    public ProblemDescription Description => new()
    {
        Name = "Maximum Subarray",
        Url = "https://leetcode.com/problems/maximum-subarray/",
        Difficulty = Difficulty.Easy,
        Text = "Given an integer array nums, find the subarray with the largest sum, and return its sum."
    };
    
    
    /*
       Given an integer array nums, find the subarray with the largest sum, and return its sum.
       
       Example 1:
       Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
       Output: 6
       Explanation: The subarray [4,-1,2,1] has the largest sum 6.
       
       Example 2:
       Input: nums = [1]
       Output: 1
       Explanation: The subarray [1] has the largest sum 1.
       Example 3:
       
       Input: nums = [5,4,-1,7,8]
       Output: 23
       Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.
    */
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