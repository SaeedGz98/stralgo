using System;
using System.Linq;

namespace _1D_DynamicProgramming.CoinChange
{
    public static class CoinChangeProblem
    {
        public static int CoinChange(int[] coins, int amount)
        {
            int[] dp = Enumerable.Repeat(amount + 1, amount + 1).ToArray();
            dp[0] = 0;

            foreach (var coin in coins)
            {
                for (int num = 1; num < amount + 1; num++)
                {
                    if (num >= coin)
                    {
                        dp[num] = Math.Min(dp[num], 1 + dp[num - coin]);
                    }
                }
            }

            return dp[amount] != amount + 1 ? dp[amount] : -1;
        }
    }
}