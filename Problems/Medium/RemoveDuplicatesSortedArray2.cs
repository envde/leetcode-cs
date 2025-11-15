using LeetCode.Common;

namespace LeetCode.Problems.Medium;

public class RemoveDuplicatesSortedArray2: ProblemDefault<(int[] Data, int Expected)>
{
    protected override (string Result, string Expected) Execute((int[] Data, int Expected) inputItem)
    {
        var result = RemoveDuplicates(inputItem.Data);
        return (result.ToString(), inputItem.Expected.ToString());
    }

    protected override IReadOnlyList<(int[] Data, int Expected)> InputValues =>
    [
        ([1,1,1,2,2,3], 5),
        ([0,0,1,1,1,1,2,3,3], 7)
    ];

    public override ProblemDescription Description => new()
    {
        Name = "Remove Duplicates from Sorted Array II",
        Url = "https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii",
        Difficulty = Difficulty.Medium
    };
    
    public int RemoveDuplicates(int[] nums)
    {
        var k = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (k < 2 || nums[i] != nums[k - 2])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}