using System;
using System.Linq;

namespace _1D_DynamicProgramming.LongestIncreasingSubsequence
{
    public static class LongestIncreasingSubsequenceProblem
    {
        public static int LengthOfLIS(int[] nums)
        {
            int[] lis = Enumerable.Repeat(1, nums.Length).ToArray();

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        lis[i] = Math.Max(lis[i], 1 + lis[j]);
                    }
                }
            }

            return lis.Max();
        }
    }
}