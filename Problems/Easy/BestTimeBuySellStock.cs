using LeetCode.Common;

namespace LeetCode.Problems.Easy;

public class BestTimeBuySellStock : IProblem
{
    public IList<ProblemResult> Solve()
    {
        IReadOnlyList<(int[], int)> inputValues =
        [
            ([7, 1, 5, 3, 6, 4], 5),
            ([7, 6, 4, 3, 1], 0),
            ([2, 4, 1], 2)
        ];

        var problemResults = inputValues.Execute(MaxProfit, result => result.ToString());
        return problemResults;
    }

    public ProblemDescription Description => new()
    {
        Name = "Best Time to Buy and Sell Stock",
        Url = "https://leetcode.com/problems/best-time-to-buy-and-sell-stock/",
        Text =
            "You are given an array prices where prices[i] is the price of a given stock on the ith day.\n" +
            "You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.\n" +
            "Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.",
        Difficulty = Difficulty.Easy
    };


    /*
       You are given an array prices where prices[i] is the price of a given stock on the ith day.

       You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

       Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

       Example 1:
       Input: prices = [7,1,5,3,6,4]
       Output: 5
       Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
       Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
       
       Example 2:
       Input: prices = [7,6,4,3,1]
       Output: 0
       Explanation: In this case, no transactions are done and the max profit = 0.

    */
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