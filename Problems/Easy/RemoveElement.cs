using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class RemoveElement: ProblemDefault<(int[] Nums, int Val, int Expected)>
{
    protected override (string Result, string Expected) Execute((int[] Nums, int Val, int Expected) inputItem)
    {
        var result = RunRemoveElement(inputItem.Nums, inputItem.Val);
        return (result.ToString(), inputItem.Expected.ToString());
    }

    public override ProblemDescription Description => new()
    {
        Name = "Remove Element",
        Url = "https://leetcode.com/problems/remove-element/description/",
        Difficulty = Difficulty.Easy
    };
    

    protected override IReadOnlyList<(int[] Nums, int Val, int Expected)> InputValues =>
    [
        ([3, 2, 2, 3], 3, 2),
        ([0,1,2,2,3,0,4,2], 2, 5)
    ];
    
    /*
     * Input: nums = [3,2,2,3], val = 3
       Output: 2, nums = [2,2,_,_]
     */
    private static int RunRemoveElement(int[] nums, int val)
    {
        var k = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val) continue;
            nums[k] = nums[i];
            k++;
        }

        return k;
    }
}