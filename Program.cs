using LeetCode.Common;
using LeetCode.Problems.Easy;

// Register problems here.
IReadOnlyList<IProblem> problems =
[
    // new TwoSumProblem(),
    // new BestTimeBuySellStock(),
    // new MaximumSubarray(),
    // new MergeSortedArray(),
    // new RemoveDuplicatesSortedArray(),
    new RemoveElement()
];

//ConsoleRenderer.RenderProblems(problems);


/*
   Input: nums = [1,1,1,2,2,3]
   Output: 5, nums = [1,1,2,2,3,_]
 */

int[] array = [1, 1, 1, 2, 2, 3];

int RemoveDuplicates(int[] nums)
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

Console.WriteLine(RemoveDuplicates(array));
Console.WriteLine(array.ToLeetCodeString());