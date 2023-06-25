namespace BitManipulation.CountingBits
{
    public class CountingBitsProblem
    {
        public static int[] CountBits(int n)
        {
            int[] dp = Enumerable.Repeat(0, n + 1).ToArray();
            int offset = 1;

            for (var i = 1; i < n + 1; i++)
            {
                if (offset * 2 == i)
                    offset = i;

                dp[i] = 1 + dp[i - offset];
            }

            return dp;
        }
    }
}