using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class MergeSortedArray: ProblemDefault<(int[] Nums1, int M, int[] Nums2, int N, int[] Expected)>
{
    protected override (string Result, string Expected) Execute((int[] Nums1, int M, int[] Nums2, int N, int[] Expected) inputItem)
    {
        var result = Merge(inputItem.Nums1, inputItem.M, inputItem.Nums2, inputItem.N);
        return (result.ToLeetCodeString(), inputItem.Expected.ToLeetCodeString());
    }

    public override ProblemDescription Description => new()
    {
        Name = "Merge Sorted Array",
        Url = "https://leetcode.com/problems/merge-sorted-array/",
        Difficulty = Difficulty.Easy
    };

    protected override IReadOnlyList<(int[] Nums1, int M, int[] Nums2, int N, int[] Expected)> InputValues =>
    [
        ([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3, [1, 2, 2, 3, 5, 6]),
        ([1], 1, [], 0, [1]),
        ([0], 0, [1], 1, [1])
    ];
    
    public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var i = m - 1; // last index in nums1
        var j = n - 1; // last index in nums2

        for (var k = m + n - 1; k >= 0 && j >= 0; k--)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
        }

        return nums1;
    }
}