namespace _2D_DynamicProgramming.BestTimetoBuyandSellStockwithCooldown
{
    public static class BestTimetoBuyandSellStockwithCooldownProblem
    {
        // State: Buying or Selling?
        // If Buy -> i + 1
        // If Sell -> i + 2

        public static int MaxProfit(int[] prices)
        {
            Dictionary<(int, bool), int> dp = new();

            int dfs(int i, bool buying)
            {
                if (i >= prices.Length)
                    return 0;

                if (dp.ContainsKey((i, buying)))
                    return dp[(i, buying)];

                int cooldown = dfs(i + 1, buying);

                if (buying)
                {
                    int buy = dfs(i + 1, !buying) - prices[i];
                    dp[(i, buying)] = Math.Max(buy, cooldown);
                }
                else
                {
                    int sell = dfs(i + 2, !buying) + prices[i];
                    dp[(i, buying)] = Math.Max(sell, cooldown);
                }

                return dp[(i, buying)];
            }

            return dfs(0, true);
        }
    }
}