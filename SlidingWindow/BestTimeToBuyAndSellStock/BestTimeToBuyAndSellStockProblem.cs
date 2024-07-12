using System;

namespace SlidingWindow.BestTimeToBuyAndSellStock
{
    /// RECOMMENDED
    public static class BestTimeToBuyAndSellStockProblem
    {
        public static int MaxProfit(int[] prices)
        {
            int left = 0, right = 1;
            int maxProfit = 0;

            while (right < prices.Length)
            {
                if (prices[left] < prices[right])
                {
                    int profit = prices[right] - prices[left];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                {
                    left = right;
                }

                right++;
            }

            return maxProfit;
        }
    }
}