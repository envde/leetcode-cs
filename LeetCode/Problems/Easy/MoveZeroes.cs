using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class MoveZeroes: ProblemDefault<(int[] Data, int[] Expected)>
{
    protected override (string Result, string Expected) Execute((int[] Data, int[] Expected) inputItem)
    {
        var result = DoMoveZeroes(inputItem.Data);
        return (result.ToLeetCodeString(), inputItem.Expected.ToLeetCodeString());
    }

    protected override IReadOnlyList<(int[] Data, int[] Expected)> InputValues =>
    [
        ([0,1,0,3,12], [1,3,12,0,0]),
        ([0], [0]),
        ([1], [1])
    ];

    public override ProblemDescription Description => new()
    {
        Name = "Move Zeroes",
        Url = "https://leetcode.com/problems/move-zeroes",
        Difficulty = Difficulty.Easy
    };
    
    /*
     * Input: nums = [0,1,0,3,12]
       Output: [1,3,12,0,0]
     */
    public int[] DoMoveZeroes(int[] nums)
    {
        var k = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) continue;
            (nums[k], nums[i]) = (nums[i], nums[k]);
            k++;
        }

        return nums;

    }
}