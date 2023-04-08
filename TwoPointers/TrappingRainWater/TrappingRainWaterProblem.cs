using System;

namespace TwoPointers.TrappingRainWater
{
    public static class TrappingRainWaterProblem
    {
        public static int Trap(int[] height)
        {
            if (height.Length == 0)
                return 0;

            int left = 0, right = height.Length - 1;
            int maxLeft = height[left], maxRight = height[right], maxWater = 0;

            while (left != right)
            {
                if (maxLeft < maxRight)
                {
                    left++;
                    maxWater += ((maxLeft - height[left]) < 0 ? 0 : (maxLeft - height[left]));
                    maxLeft = Math.Max(maxLeft, height[left]);
                }
                else
                {
                    right--;
                    maxWater += ((maxRight - height[right]) < 0 ? 0 : (maxRight - height[right]));
                    maxRight = Math.Max(maxRight, height[right]);
                }
            }

            return maxWater;
        }
    }
}