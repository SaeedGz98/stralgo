using System;

namespace _1D_DynamicProgramming.HouseRobberII
{
    public static class HouseRobberIIProblem
    {
        public static int Rob(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            return Math.Max(RobThisPart(nums[..^1]), RobThisPart(nums[1..]));
        }

        public static int RobThisPart(int[] nums)
        {
            int rob1 = 0, rob2 = 0;

            foreach (var num in nums)
            {
                (rob1, rob2) = (rob2, Math.Max(num + rob1, rob2));
            }

            return rob2;
        }
    }
}