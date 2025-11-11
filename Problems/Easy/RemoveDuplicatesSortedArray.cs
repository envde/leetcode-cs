using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class RemoveDuplicatesSortedArray: ProblemDefault<(int[] Data, int Expected)>
{
    protected override (string Result, string Expected) Execute((int[] Data, int Expected) inputItem)
    {
        var result = RemoveDuplicates(inputItem.Data);
        return (result.ToString(), inputItem.Expected.ToString());
    }

    protected override IReadOnlyList<(int[] Data, int Expected)> InputValues =>
    [
        ([1, 1, 2], 2),
        ([0, 0, 1, 1, 1, 2, 2, 3, 3, 4], 5)
    ];

    public override ProblemDescription Description => new()
    {
        Name = "Remove Duplicates from Sorted Array",
        Url = "https://leetcode.com/problems/remove-duplicates-from-sorted-array/",
        Difficulty = Difficulty.Easy
    };
    
    public int RemoveDuplicates(int[] nums)
    {
        var k = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}