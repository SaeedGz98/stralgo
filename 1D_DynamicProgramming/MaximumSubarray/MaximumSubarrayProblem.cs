﻿using System;

namespace _1D_DynamicProgramming.MaximumSubarray
{
    /// RECOMMENDED
    public static class MaximumSubarrayProblem
    {
        public static int MaxSubArray(int[] nums)
        {
            int maxSub = nums[0];
            int curSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (curSum < 0)
                {
                    curSum = 0;
                }
                curSum += nums[i];
                maxSub = Math.Max(maxSub, curSum);
            }
            return maxSub;
        }
    }
}