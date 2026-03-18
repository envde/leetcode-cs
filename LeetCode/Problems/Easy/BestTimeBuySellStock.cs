using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class BestTimeBuySellStock : ProblemDefault<(int[] Data, int Expected)>
{
    protected override (string Result, string Expected) Execute((int[] Data, int Expected) inputItem)
    {
        var result = MaxProfit(inputItem.Data);
        return (result.ToString(), inputItem.Expected.ToString());
    }

    public override ProblemDescription Description => new()
    {
        Name = "Best Time to Buy and Sell Stock",
        Url = "https://leetcode.com/problems/best-time-to-buy-and-sell-stock/",
        Difficulty = Difficulty.Easy
    };

    protected override IReadOnlyList<(int[], int)> InputValues =>
    [
        ([7, 1, 5, 3, 6, 4], 5),
        ([7, 6, 4, 3, 1], 0 ),
        ([2, 4, 1], 2)
    ];
    
    private static int MaxProfit(int[] prices)
    {
        if (prices.Length < 2) return 0;

        var minPrice = prices[0];
        var profit = 0;

        for (int i = 1; i < prices.Length; i++) {

            var currentPrice = prices[i];

            if (currentPrice < minPrice) {
                minPrice = currentPrice;
            } else if (currentPrice - minPrice > profit) {
                profit = currentPrice - minPrice;
            }
        }

        return profit;
    }
}