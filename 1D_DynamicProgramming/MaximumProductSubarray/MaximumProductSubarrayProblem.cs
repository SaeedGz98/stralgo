using System;
using System.Linq;

namespace _1D_DynamicProgramming.MaximumProductSubarray
{
    public static class MaximumProductSubarrayProblem
    {
        public static int MaxProduct(int[] nums)
        {
            int res = nums.Max();
            int curMin = 1, curMax = 1;

            foreach (int num in nums)
            {
                int tmp = num * curMax;
                curMax = new int[] { num * curMax, num * curMin, num }.Max();
                curMin = new int[] { tmp, num * curMin, num }.Min();

                res = Math.Max(res, curMax);
            }

            return res;
        }
    }
}