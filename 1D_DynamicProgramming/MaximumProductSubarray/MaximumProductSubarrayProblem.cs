using System;
using System.Linq;

namespace _1D_DynamicProgramming.MaximumProductSubarray
{
    /// RECOMMENDED
    public static class MaximumProductSubarrayProblem
    {
        public static int MaxProduct(int[] nums)
        {
            double res = nums[0];
            double curMin = 1, curMax = 1;

            foreach (int num in nums)
            {
                double tmp = num * curMax;
                curMax = Math.Max(Math.Max(num * curMax, num * curMin), num);
                curMin = Math.Min(Math.Min(tmp, num * curMin), num);

                res = Math.Max(res, curMax);
            }

            return (int)res;
        }

        public static int MaxProduct2(int[] nums)
        {
            int length = nums.Length;
            double leftProduct = 1;
            double rightProduct = 1;
            double asnwer = nums[0];

            for (int i = 0; i < length; i++)
            {
                leftProduct = leftProduct == 0 ? 1 : leftProduct;
                rightProduct = rightProduct == 0 ? 1 : rightProduct;

                leftProduct *= nums[i];
                rightProduct *= nums[^(i + 1)];

                asnwer = Math.Max(asnwer, Math.Max(leftProduct, rightProduct));
            }

            return (int)asnwer;
        }
    }
}