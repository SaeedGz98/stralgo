using System;

namespace SlidingWindow.TimeToBuySellStock
{
    public static class TimeToBuySellStockProblem
    {
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0, left = 0, right = 1;

            while (right < prices.Length)
            {
                if (prices[left] < prices[right])
                    maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
                else
                    left = right;

                right++;
            }

            return maxProfit;
        }
    }
}